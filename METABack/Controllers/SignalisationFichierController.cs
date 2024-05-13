using METABack.Entities;
using METABack.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace METABack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignalisationFichierController : ControllerBase
    {
        private readonly ISignalisationFichier _ISignalisationFichier;
        private readonly DatabaseContext _dbContext;
        public SignalisationFichierController(ISignalisationFichier ISignalisationFichier, DatabaseContext dbContext) {
            _ISignalisationFichier = ISignalisationFichier;
            _dbContext = dbContext;
        }

        
        [HttpPost("upload/{codeSignalisation}")]
        public async Task<IActionResult> Upload(List<IFormFile> lstFiles,int codeSignalisation)
        {
            if (lstFiles == null || lstFiles.Count == 0)
                return BadRequest("Aucun fichier n'a été envoyé.");

            try
            {
                using (var memoryStream = new MemoryStream())
                {
                    foreach (var item in lstFiles)
                    {
                        await item.CopyToAsync(memoryStream);
                        var signalisationFichier = new SignalisationFichier
                        {
                            NomFichier = item.FileName,
                            CodeSignalisation = codeSignalisation,
                            Extension = Path.GetExtension(item.FileName),
                            Data = memoryStream.ToArray()
                        };
                        _dbContext.SignalisationFichiers.Add(signalisationFichier);
                        await _dbContext.SaveChangesAsync();
                    }
                        
                }

                return Ok("Fichier téléchargé avec succès.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Une erreur s'est produite lors du téléchargement du fichier : " + ex.Message);
            }
        }

    }
}
