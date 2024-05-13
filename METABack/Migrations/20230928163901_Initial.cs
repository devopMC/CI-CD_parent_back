using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace METABack.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activite_fiche",
                columns: table => new
                {
                    codeAct = table.Column<int>(type: "int", nullable: false),
                    Codegouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Annescol = table.Column<int>(type: "int", nullable: true),
                    CodeSecFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeNatAct = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateAct = table.Column<DateTime>(type: "date", nullable: true),
                    SujetAct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LieuAct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NbFemme = table.Column<int>(type: "int", nullable: true),
                    NbHomme = table.Column<int>(type: "int", nullable: true),
                    Typepart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    daterapport = table.Column<DateTime>(type: "datetime", nullable: true),
                    codeutilrapport = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ActiviteAct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datecreation = table.Column<DateTime>(type: "datetime", nullable: true),
                    Codeutil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Datemodification = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodeutilM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activite_fiche", x => x.codeAct);
                });

            migrationBuilder.CreateTable(
                name: "Activite_paraticipant",
                columns: table => new
                {
                    codeAct = table.Column<int>(type: "int", nullable: true),
                    CodeUtil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionGroupeTrancheAge_old01122020",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeTranAge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombGrou = table.Column<int>(type: "int", nullable: true),
                    NombPersPourGrou = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionGroupeTrancheAge_old02122020",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeTranAge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombGrou = table.Column<int>(type: "int", nullable: true),
                    NombPersPourGrou = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionTrancheAge_old02122020",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeTranAge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumeGrou = table.Column<int>(type: "int", nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_Club",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeTypeClub = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrixClub = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NbInscrit = table.Column<int>(type: "int", nullable: true),
                    nbseance = table.Column<int>(type: "int", nullable: true),
                    NomClub = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_Club", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.CodeTypeClub });
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_ClubGeneral",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    PrixClub = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NbInscrit = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_ClubGeneral", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol });
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_ClubGeneral_05012022",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    PrixClub = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NbInscrit = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_EnfantNE",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    idenfant = table.Column<int>(type: "int", nullable: false),
                    dateinscrit = table.Column<DateTime>(type: "date", nullable: false),
                    datearret = table.Column<DateTime>(type: "date", nullable: true),
                    motifarret = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datecreation = table.Column<DateTime>(type: "datetime", nullable: true),
                    codeutiladd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dateMod = table.Column<DateTime>(type: "datetime", nullable: true),
                    codeutilMod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    activ = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_HistoriqueEtatEtab",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeEtatEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateModif = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreationEtatb = table.Column<bool>(type: "bit", nullable: true),
                    ChangementAdresse = table.Column<bool>(type: "bit", nullable: true),
                    AdresseEtablissement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChangementDitecteur = table.Column<bool>(type: "bit", nullable: true),
                    CINResponsable = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    codeutilisateur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_lienexterne",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeLienExterne = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    @checked = table.Column<bool>(name: "checked", type: "bit", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_lienexterne", x => new { x.CodeEtab, x.AnneScol, x.CodeLienExterne });
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_Terrain",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeTerrain = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_Terrain", x => new { x.CodeEtab, x.AnneScol, x.CodeTerrain });
                });

            migrationBuilder.CreateTable(
                name: "Event_fiche",
                columns: table => new
                {
                    codeEvent = table.Column<int>(type: "int", nullable: false),
                    Codegouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Annescol = table.Column<int>(type: "int", nullable: true),
                    CodeSecFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NomEvent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeNivFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateEvent = table.Column<DateTime>(type: "date", nullable: true),
                    OrgEvent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LieuEvent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NbFemmeC = table.Column<int>(type: "int", nullable: true),
                    NbHommeC = table.Column<int>(type: "int", nullable: true),
                    NbFemmeE = table.Column<int>(type: "int", nullable: true),
                    NbHommeE = table.Column<int>(type: "int", nullable: true),
                    PrixEvent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InvesEvent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    daterapport = table.Column<DateTime>(type: "datetime", nullable: true),
                    codeutilrapport = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ActiviteEvent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datecreation = table.Column<DateTime>(type: "datetime", nullable: true),
                    Codeutil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Datemodification = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodeutilM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event_fiche", x => x.codeEvent);
                });

            migrationBuilder.CreateTable(
                name: "Event_paraticipant",
                columns: table => new
                {
                    codeEvent = table.Column<int>(type: "int", nullable: true),
                    CodeUtil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Formation_Corps",
                columns: table => new
                {
                    codeformation = table.Column<int>(type: "int", nullable: true),
                    CodeCorps = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Formation_fiche",
                columns: table => new
                {
                    codeformation = table.Column<int>(type: "int", nullable: false),
                    Codegouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Annescol = table.Column<int>(type: "int", nullable: true),
                    CodeSecFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeNivFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeNatFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dateformation = table.Column<DateTime>(type: "date", nullable: true),
                    NbJourFomration = table.Column<int>(type: "int", nullable: true),
                    NbheureFormation = table.Column<int>(type: "int", nullable: true),
                    SujetFormation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LieurFormation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButFormation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NbFemme = table.Column<int>(type: "int", nullable: true),
                    NbHomme = table.Column<int>(type: "int", nullable: true),
                    Organisation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inspecteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeCerc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NomFormateur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeNatFormateur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PrixFormation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InvesFormation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    daterapport = table.Column<DateTime>(type: "datetime", nullable: true),
                    codeutilrapport = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Activiteformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datecreation = table.Column<DateTime>(type: "datetime", nullable: true),
                    Codeutil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Datemodification = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodeutilM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formation_Fiche", x => x.codeformation);
                });

            migrationBuilder.CreateTable(
                name: "Formation_Inspecteur",
                columns: table => new
                {
                    codeformation = table.Column<int>(type: "int", nullable: true),
                    CodeUtil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Formation_paraticipant",
                columns: table => new
                {
                    codeformation = table.Column<int>(type: "int", nullable: true),
                    CodeUtil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Formation_TypeEtablissement",
                columns: table => new
                {
                    codeformation = table.Column<int>(type: "int", nullable: true),
                    CodeTypeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Inspection_Club",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeTypeClub = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeClub = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PrixClub = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NbInscrit = table.Column<int>(type: "int", nullable: true),
                    nbseance = table.Column<int>(type: "int", nullable: true),
                    NomClub = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Inspection_ElevePresent",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeElevePresent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeElevePresent = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true),
                    NombTota = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_ElevePresent", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.CodeElevePresent });
                });

            migrationBuilder.CreateTable(
                name: "Inspection_EnfantNE",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    idenfant = table.Column<int>(type: "int", nullable: false),
                    nomprenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateNais = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    nompere = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dateinscrit = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Inspection_FichierJoint",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    NumeFichJoin = table.Column<int>(type: "int", nullable: false),
                    PhysNameFile = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UploNameFile = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CodeUtil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOper = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_FichierJoint", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.NumeFichJoin });
                });

            migrationBuilder.CreateTable(
                name: "Inspection_Infrastructure_Autre",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    @checked = table.Column<bool>(name: "checked", type: "bit", nullable: true),
                    CodetypeInfra = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeInfrastrcture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LBChecked = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Inspection_intervention",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeInterv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeInterv = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CodeTypeInterv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTypeInterv = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Inspection_Lienexterne",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeLienExterne = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeLienExterne = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Inspection_NiveauEtude",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeNivEle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeNivEle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Nombenfant = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_NiveauEtude", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.CodeNivEle });
                });

            migrationBuilder.CreateTable(
                name: "Inspection_RepartitionPersonel",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    IdenUniq = table.Column<int>(type: "int", nullable: false),
                    NomPren = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LibeGenr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateNais = table.Column<DateTime>(type: "date", nullable: true),
                    LibeNiveEtud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeGrad = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LibeFonc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StructureAttache = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    daterecrutement = table.Column<DateTime>(type: "date", nullable: true),
                    dateaffectation = table.Column<DateTime>(type: "date", nullable: true),
                    daterespons = table.Column<DateTime>(type: "date", nullable: true),
                    notePead = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datenotePead = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdenUniqMatrCnss = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_RepartitionPersonel", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.IdenUniq });
                });

            migrationBuilder.CreateTable(
                name: "Inspection_RepartitionTrancheAgeArretEtude",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    LibeTranAge = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true),
                    NombTota = table.Column<int>(type: "int", nullable: true),
                    CodeTranAge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Inspection_RepartitionTrancheAgeBeneficaire",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    LibeTranAge = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true),
                    NombTota = table.Column<int>(type: "int", nullable: true),
                    CodeTranAge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Inspection_RepartitionTrancheAgeTypePriseEnCharge",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeTranAge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodeTypePrisChar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true),
                    LibeTranAge = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    libeTypePrisChar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombTota = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Inspection_RepartitionTypePriseEnCharge",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeTypePrisChar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true),
                    libeTypePrisChar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombTota = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "message_recuuser",
                columns: table => new
                {
                    idmessage = table.Column<int>(type: "int", nullable: false),
                    CodeUtil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    daterecu = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_message_recuuser", x => new { x.idmessage, x.CodeUtil });
                });

            migrationBuilder.CreateTable(
                name: "Nome_TypeFichierJoint",
                columns: table => new
                {
                    CodeTypefich = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    LibeTypeFich = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    iconTypeFich = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nome_TypeFichierJoint", x => x.CodeTypefich);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_activite",
                columns: table => new
                {
                    Codeactivite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Libeactivite = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    afficheeleve = table.Column<int>(type: "int", nullable: true),
                    afficheniveau = table.Column<int>(type: "int", nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_activite", x => x.Codeactivite);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Anomalie",
                columns: table => new
                {
                    CodeAnom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Commune"),
                    LibeAnom = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Anomalie", x => x.CodeAnom);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_CaracteristiqueEspaceExterieur",
                columns: table => new
                {
                    CodeCaraEspaExte = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "خصائص الفضاء الخارجي"),
                    LibeCaraEspaExte = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_CaracteristiqueEspaceExterieur", x => x.CodeCaraEspaExte);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_CategorieRubriqueActivite",
                columns: table => new
                {
                    Codeactivite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodeCateRubrInsp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_CategorieRubriqueActivite", x => new { x.Codeactivite, x.CodeCateRubrInsp });
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Cercle",
                columns: table => new
                {
                    CodeCerc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeCerc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeGouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Cercle", x => x.CodeCerc);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Club",
                columns: table => new
                {
                    CodeClub = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeClub = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Club", x => x.CodeClub);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Commune",
                columns: table => new
                {
                    CodeComm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Commune"),
                    LibeComm = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true),
                    CodeDele = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Commune", x => x.CodeComm);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Concerne",
                columns: table => new
                {
                    CodeConcerne = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeConcerne = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Concerne", x => x.CodeConcerne);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Constatation",
                columns: table => new
                {
                    CodeCons = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeCons = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Constatation", x => x.CodeCons);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Corps",
                columns: table => new
                {
                    CodeCorp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code corps"),
                    LibeCorp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Libellé corps(Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Corps", x => x.CodeCorp);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Couverture",
                columns: table => new
                {
                    codegouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    annescol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeTranCouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    couverture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_DecisionReclamation",
                columns: table => new
                {
                    CodeReclDeci = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Commune"),
                    LibeReclDeci = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_DecisionReclamation", x => x.CodeReclDeci);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_DedreHandicap",
                columns: table => new
                {
                    CodeDegrHand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeDegrHand = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_DedreHandicap", x => x.CodeDegrHand);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Diplome",
                columns: table => new
                {
                    CodeDipl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code diplome"),
                    LibeDipl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Libellé diplome (Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Diplome", x => x.CodeDipl);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_District",
                columns: table => new
                {
                    CodeDist = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code district"),
                    LibeDist = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Libellé district"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_District", x => x.CodeDist);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_ElevePresent",
                columns: table => new
                {
                    CodeElevePresent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeElevePresent = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_ElevePresent", x => x.CodeElevePresent);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_EmplacementEtablissement",
                columns: table => new
                {
                    CodeEmpl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "خصائص الفضاء الخارجي"),
                    LibeEmpl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Emplacement", x => x.CodeEmpl);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_EmplacementSiege",
                columns: table => new
                {
                    CodeEmplSieg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeEmplSieg = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_EmplacementSiege", x => x.CodeEmplSieg);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_EtatFamille",
                columns: table => new
                {
                    CodeEtatFam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeEtatFam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_EtatFamille", x => x.CodeEtatFam);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_EtatParent",
                columns: table => new
                {
                    CodeEtatPare = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeEtatPare = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_EtatParent", x => x.CodeEtatPare);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_EtatPsycologique",
                columns: table => new
                {
                    CodeEtatPsyc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeEtatPsyc = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_EtatPsycologique", x => x.CodeEtatPsyc);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_EtatReclamation",
                columns: table => new
                {
                    CodeEtatRecl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Commune"),
                    LibeEtatRecl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_EtatReclamation", x => x.CodeEtatRecl);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_EtatSante",
                columns: table => new
                {
                    CodeEtatSant = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeEtatSant = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_EtatSante", x => x.CodeEtatSant);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_EtatSignalisation",
                columns: table => new
                {
                    CodeEtatSignalisation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeEtatSignalisation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_EtatSignalisation", x => x.CodeEtatSignalisation);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Fonction",
                columns: table => new
                {
                    CodeFonc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code Fonction"),
                    LibeFonc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Libellé Fonction (Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Fonction", x => x.CodeFonc);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Generale",
                columns: table => new
                {
                    Pays = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ministere = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    region = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    direction = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    signature = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    nbjourupdate = table.Column<int>(type: "int", nullable: true),
                    nbjourSup = table.Column<int>(type: "int", nullable: true),
                    nbjourupdateSignalisation = table.Column<int>(type: "int", nullable: true),
                    nbjourSupSignalisation = table.Column<int>(type: "int", nullable: true),
                    DelaiInspection = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Nbjoursaisieinsp = table.Column<int>(type: "int", nullable: true),
                    nbjourupdateRapport = table.Column<int>(type: "int", nullable: true),
                    nbjoursupRapport = table.Column<int>(type: "int", nullable: true),
                    nbjourupdateEnfant = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Generale", x => x.Pays);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Genre",
                columns: table => new
                {
                    CodeGenr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code genre"),
                    LibeGenr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Libellé genre (Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Genre", x => x.CodeGenr);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Grade",
                columns: table => new
                {
                    CodeGrad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeGrad = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Grade", x => x.CodeGrad);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Informateur",
                columns: table => new
                {
                    CodeInformateur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeInformateur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Informateur", x => x.CodeInformateur);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Infrastrcture",
                columns: table => new
                {
                    CodeInfrastrcture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeInfrastrcture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Infrastrcture", x => x.CodeInfrastrcture);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_IntergrationHandicap",
                columns: table => new
                {
                    CodeInteHand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeInteHand = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_IntergrationHandicap", x => x.CodeInteHand);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Interventionnecessaire",
                columns: table => new
                {
                    CodeInterv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeInterv = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CodeTypeInterv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Interventionnecessaire", x => x.CodeInterv);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_LangueMaternelle",
                columns: table => new
                {
                    CodeLangMate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code Niveau d'Etude"),
                    LibeLangMate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Libellé Niveau d'Etude (Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: false, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))", comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_LangueMaternelle", x => x.CodeLangMate);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_LienExterne",
                columns: table => new
                {
                    CodeLienExterne = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeLienExterne = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_LienExterne", x => x.CodeLienExterne);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_MethodeSignalisation",
                columns: table => new
                {
                    CodeMethodeSignalisation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeMethodeSignalisation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_MethodeSignalisation", x => x.CodeMethodeSignalisation);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_MinistereFondatrice",
                columns: table => new
                {
                    CodeMiniFond = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeMiniFond = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: false),
                    Acti = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_MinistereFondatrice", x => x.CodeMiniFond);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Nationalite",
                columns: table => new
                {
                    CodeNati = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeNati = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Nationalite", x => x.CodeNati);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_NatureActivite",
                columns: table => new
                {
                    CodeNatAct = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeNatAct = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_NatureActivite", x => x.CodeNatAct);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_NatureAnomalie",
                columns: table => new
                {
                    CodeNatureAnomalie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LibeNatureAnomalie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Natureformateur",
                columns: table => new
                {
                    CodeNatFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeNatFor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Natureformateur", x => x.CodeNatFor);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Natureformation",
                columns: table => new
                {
                    CodeNatFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeNatFor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Natureformation", x => x.CodeNatFor);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_NatureInvest",
                columns: table => new
                {
                    CodeNatInv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeNatInv = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_NatureInvest", x => x.CodeNatInv);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_NaturePere",
                columns: table => new
                {
                    CodeNaturePere = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeNaturePere = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_NaturePere", x => x.CodeNaturePere);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_NatureProposition",
                columns: table => new
                {
                    CodeNatPro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeNatPro = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_NatureProposition", x => x.CodeNatPro);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_NatureSignalisation",
                columns: table => new
                {
                    CodeNatureSignalisation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeNatureSignalisation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_NatureSignalisation", x => x.CodeNatureSignalisation);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_NiveauEleve",
                columns: table => new
                {
                    CodeNivEle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeNivEle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_NiveauEleve", x => x.CodeNivEle);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_NiveauEtude",
                columns: table => new
                {
                    CodeNiveEtud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code Niveau d'Etude"),
                    LibeNiveEtud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Libellé Niveau d'Etude (Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: false, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))", comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_NiveauEtude", x => x.CodeNiveEtud);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_NiveauFormation",
                columns: table => new
                {
                    CodeNivFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeNivFor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_NiveauFormation", x => x.CodeNivFor);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_NiveauSalaire",
                columns: table => new
                {
                    CodeNiveSala = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code Niveau d'Etude"),
                    LibeNiveSala = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Libellé Niveau d'Etude (Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: false, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))", comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_NiveauSalaire", x => x.CodeNiveSala);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_OuvertureEtablissement",
                columns: table => new
                {
                    CodeOuveEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeOuveEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_OuvertureEtablissement", x => x.CodeOuveEtab);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Priorite",
                columns: table => new
                {
                    CodePrio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Commune"),
                    LibePrio = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Priorite", x => x.CodePrio);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Profession",
                columns: table => new
                {
                    CodeProf = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code Type Equipement"),
                    LibeProf = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "Libellée Type Equipement"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Ordre d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Profession", x => x.CodeProf);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Qualite",
                columns: table => new
                {
                    CodeQual = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code qualite"),
                    LibeQual = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Libellé qualite (Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Qualite", x => x.CodeQual);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_rectification",
                columns: table => new
                {
                    CodeRect = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeRect = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_rectification", x => x.CodeRect);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_RegimePropriete",
                columns: table => new
                {
                    CodeRegiProp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeRegiProp = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_RegimePropriete", x => x.CodeRegiProp);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_RevenuMensuel",
                columns: table => new
                {
                    CodeReveMens = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code genre"),
                    LibeReveMens = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Libellé genre (Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_RevenuMensuel", x => x.CodeReveMens);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Secteur",
                columns: table => new
                {
                    CodeSect = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code secteur"),
                    LibeSect = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Libellé secteur (Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Secteur", x => x.CodeSect);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_SecteurFormation",
                columns: table => new
                {
                    CodeSecFor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeSecFor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_SecteurFormation", x => x.CodeSecFor);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_SituationFamiliale",
                columns: table => new
                {
                    CodeSituFami = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code genre"),
                    LibeSituFami = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Libellé genre (Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_SituationFamiliale", x => x.CodeSituFami);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_SituationProfessionel",
                columns: table => new
                {
                    CodeSituProf = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeSituProf = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_SituationProfessionel", x => x.CodeSituProf);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_StatutSignalisation",
                columns: table => new
                {
                    CodeStatutSignalisation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeStatutSignalisation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeEtatSignalisation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_StatutSignalisation", x => x.CodeStatutSignalisation);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_StructureAttache",
                columns: table => new
                {
                    CodeStruAtta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeStruAtta = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_StructureAttache", x => x.CodeStruAtta);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Terrain",
                columns: table => new
                {
                    CodeTerrain = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTerrain = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Terrain", x => x.CodeTerrain);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TrancheAge",
                columns: table => new
                {
                    CodeTranAge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTranAge = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true),
                    CodeTypeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TrancheAge", x => x.CodeTranAge);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TrangeAgeCouv",
                columns: table => new
                {
                    CodeTranCouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTranCouv = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TrangeAgeCouv", x => x.CodeTranCouv);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeAffiche",
                columns: table => new
                {
                    CodeTypeAffiche = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTypeAffiche = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeAffiche", x => x.CodeTypeAffiche);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeBoolean",
                columns: table => new
                {
                    Code = table.Column<bool>(type: "bit", nullable: false),
                    Libe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeBoolean", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeCloture",
                columns: table => new
                {
                    CodeTypeClot = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "خصائص الفضاء الخارجي"),
                    LibeTypeClot = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeCloture", x => x.CodeTypeClot);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeConnexionInternet",
                columns: table => new
                {
                    CodeTypeConnInte = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "خصائص الفضاء الخارجي"),
                    LibeTypeConnInte = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeConnexionInternet", x => x.CodeTypeConnInte);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeEquipement",
                columns: table => new
                {
                    CodeTypeEqui = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTypeEqui = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Ordre d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeEquipement", x => x.CodeTypeEqui);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeEspace",
                columns: table => new
                {
                    CodeTypeEspa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code Type Equipement"),
                    LibeTypeEspa = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, comment: "Libellée Type Equipement"),
                    CaraEspa = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Ordre d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeEspace", x => x.CodeTypeEspa);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeEtablissement",
                columns: table => new
                {
                    CodeTypeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code type établissement"),
                    LibeTypeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Libellé type établissement (Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)"),
                    Formulaire = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true, defaultValueSql: "((1))"),
                    CodeFormulaire = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeEtablissement", x => x.CodeTypeEtab);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeEtatEtablissement",
                columns: table => new
                {
                    CodeTypeEtatEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTypeEtatEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeEtatEtablissement", x => x.CodeTypeEtatEtab);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeFormation",
                columns: table => new
                {
                    CodeTypeForm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTypeForm = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeFormation", x => x.CodeTypeForm);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeFormulaire",
                columns: table => new
                {
                    CodeFormulaire = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeFormulaire = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeFormulaire", x => x.CodeFormulaire);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeHandicap",
                columns: table => new
                {
                    CodeTypeHand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTypeHand = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeHandicap", x => x.CodeTypeHand);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeInscription",
                columns: table => new
                {
                    CodeTypeInsc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code Type Equipement"),
                    LibeTypeInsc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, comment: "Libellée Type Equipement"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Ordre d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeInscription", x => x.CodeTypeInsc);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeInspection",
                columns: table => new
                {
                    CodeTypeInsp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTypeInsp = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeInspection", x => x.CodeTypeInsp);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeIntervention",
                columns: table => new
                {
                    CodeTypeInterv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTypeInterv = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeIntervention", x => x.CodeTypeInterv);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeMessage",
                columns: table => new
                {
                    CodeTypeM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTypeM = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeMessage", x => x.CodeTypeM);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypePriseEnCharge",
                columns: table => new
                {
                    CodeTypePrisChar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code Niveau d'Etude"),
                    LibeTypePrisChar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Libellé Niveau d'Etude (Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: false, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))", comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypePriseEnCharge", x => x.CodeTypePrisChar);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Typeproposition",
                columns: table => new
                {
                    CodetypePro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibetypePro = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Typeproposition", x => x.CodetypePro);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypePropriete",
                columns: table => new
                {
                    CodeTypeProp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTypeProp = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypePropriete", x => x.CodeTypeProp);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeRepartition",
                columns: table => new
                {
                    CodeTypeRepar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTypeRepar = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeRepartition", x => x.CodeTypeRepar);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_TypeSignalisation",
                columns: table => new
                {
                    CodeTypeSignalisation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeTypeSignalisation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_TypeS", x => x.CodeTypeSignalisation);
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Zone",
                columns: table => new
                {
                    CodeZone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code zone (Urbain/rurale)"),
                    LibeZone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Libellé zone (Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Zone", x => x.CodeZone);
                });

            migrationBuilder.CreateTable(
                name: "Parametrage_AnneeScolaire",
                columns: table => new
                {
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    Obse = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DateInit = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodeUtil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametrage_AnneeScolaire", x => x.AnneScol);
                });

            migrationBuilder.CreateTable(
                name: "Parametrage_ColumnRechercheMultiCritere",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_Cube = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Area = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    AreaIndex = table.Column<int>(type: "int", nullable: true),
                    Visi = table.Column<bool>(type: "bit", nullable: true),
                    SummaryType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CellFormatType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CellFormatString = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametrage_ColumnRechercheMultiCritere", x => new { x.id, x.id_Cube });
                });

            migrationBuilder.CreateTable(
                name: "Parametrage_CubeAnalyse",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    NomCube = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Requ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametrage_CubeAnalyse", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Parametrage_DimensionCube",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_Cube = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Area = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true),
                    AreaIndex = table.Column<int>(type: "int", nullable: true),
                    Visi = table.Column<bool>(type: "bit", nullable: true),
                    SummaryType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CellFormatType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CellFormatString = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametrage_DimensionCube", x => new { x.id, x.id_Cube });
                });

            migrationBuilder.CreateTable(
                name: "Parametrage_GroupeNomenclature",
                columns: table => new
                {
                    CodeGrou = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeGrou = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametrage_GroupeNomenclature", x => x.CodeGrou);
                });

            migrationBuilder.CreateTable(
                name: "Parametrage_NomencaltureActivite",
                columns: table => new
                {
                    codeenti = table.Column<int>(type: "int", nullable: true),
                    CodeActivite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeNoma = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Parametrage_NomencaltureTypeEtab",
                columns: table => new
                {
                    codeenti = table.Column<int>(type: "int", nullable: true),
                    CodeTypeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeNoma = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Parametrage_Nomenclature",
                columns: table => new
                {
                    NumeNome = table.Column<int>(type: "int", nullable: false),
                    NomTable = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LibeNome = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CodeEnti = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    CodeGrou = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    SpDelete = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametrage_Nomenclature", x => x.NumeNome);
                });

            migrationBuilder.CreateTable(
                name: "Parametrage_RechercheMultiCritere",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametrage_RechercheMultiCritere_1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Passation_fiche",
                columns: table => new
                {
                    codePas = table.Column<int>(type: "int", nullable: false),
                    Codegouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Annescol = table.Column<int>(type: "int", nullable: true),
                    DatePas = table.Column<DateTime>(type: "date", nullable: true),
                    EtabPas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADirecteur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arefrence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Directeur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    refrence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    daterapport = table.Column<DateTime>(type: "datetime", nullable: true),
                    codeutilrapport = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ActivitePas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datecreation = table.Column<DateTime>(type: "datetime", nullable: true),
                    Codeutil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Datemodification = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodeutilM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passation_fiche", x => x.codePas);
                });

            migrationBuilder.CreateTable(
                name: "Passation_paraticipant",
                columns: table => new
                {
                    codePas = table.Column<int>(type: "int", nullable: true),
                    CodeUtil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Personnel_Fiche",
                columns: table => new
                {
                    NumeCIN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DateCIN = table.Column<DateTime>(type: "datetime", nullable: true),
                    NomPren = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CodeGenr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateNais = table.Column<DateTime>(type: "datetime", nullable: true),
                    LieuNais = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdenUniqMatrCnss = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeNiveEtud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeDipl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeSituFami = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdrePers = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CodePost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeDele = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeGrad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeQual = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Anci = table.Column<double>(type: "float", nullable: true),
                    CodeCorp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Spec = table.Column<bool>(type: "bit", nullable: true),
                    Elig = table.Column<bool>(type: "bit", nullable: true),
                    CodeReveMens = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelGSM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StructureAttache = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    daterecrutement = table.Column<DateTime>(type: "date", nullable: true),
                    dateaffectation = table.Column<DateTime>(type: "date", nullable: true),
                    daterespons = table.Column<DateTime>(type: "date", nullable: true),
                    notePead = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datenotePead = table.Column<DateTime>(type: "date", nullable: true),
                    AnotePead = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdatenotePead = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    codeutiladd = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Proposition_fiche",
                columns: table => new
                {
                    codePro = table.Column<int>(type: "int", nullable: false),
                    Codegouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Annescol = table.Column<int>(type: "int", nullable: true),
                    DatePro = table.Column<DateTime>(type: "date", nullable: true),
                    CodeTypePro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeNatPro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sujet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datecreation = table.Column<DateTime>(type: "datetime", nullable: true),
                    Codeutil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Datemodification = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodeutilM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposition_fiche", x => x.codePro);
                });

            migrationBuilder.CreateTable(
                name: "Rapport_Fichier",
                columns: table => new
                {
                    CodeFichier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: true),
                    TypeRapport = table.Column<int>(type: "int", nullable: true),
                    NomFichier = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rapport_Fichier", x => x.CodeFichier);
                });

            migrationBuilder.CreateTable(
                name: "Securite_AttacheInspecteur",
                columns: table => new
                {
                    CodeAideInspecteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeInspecteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    codeCodeutil_ADD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Securite_Directeur",
                columns: table => new
                {
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pwd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeEtab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Etat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Securite_Etablissement_15112020",
                columns: table => new
                {
                    CODEUTIL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CodeEtab = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Securite_Etablissement_historique",
                columns: table => new
                {
                    CODEUTIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Securite_Etablissement_Trace",
                columns: table => new
                {
                    codeutil = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    codeutil_securite = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    dateoperaion = table.Column<DateTime>(type: "datetime", nullable: true),
                    operation = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    detail = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SECURITE_GROUPEUTILISATEUR",
                columns: table => new
                {
                    CODEGROUUTIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LIBEGROUUTIL = table.Column<string>(type: "nvarchar(510)", maxLength: 510, nullable: false),
                    OBSE = table.Column<string>(type: "nvarchar(510)", maxLength: 510, nullable: true),
                    CodeGrouUtilPare = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECURTIE_GROUPEUTILISATEUR", x => x.CODEGROUUTIL);
                });

            migrationBuilder.CreateTable(
                name: "SECURITE_NIVEAUHIERARCHIQUE",
                columns: table => new
                {
                    CODENIVEHIER = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LIBENIVEHIER = table.Column<string>(type: "nvarchar(510)", maxLength: 510, nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECURITE_NIVEAUHIERARCHIQUE", x => x.CODENIVEHIER);
                });

            migrationBuilder.CreateTable(
                name: "SECURITE_PACKAGE",
                columns: table => new
                {
                    CODEPACK = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LIBEPACK = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ORDRAFFI = table.Column<int>(type: "int", nullable: true),
                    URI = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsVisi = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECURITE_PACKAGE", x => x.CODEPACK);
                });

            migrationBuilder.CreateTable(
                name: "Securite_Siganlisation",
                columns: table => new
                {
                    codeutil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    valeur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SECURITE_TYPEOPERATIONTRACE",
                columns: table => new
                {
                    CODETYPEOPERTRAC = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LIBETYPEOPERTRAC = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OBSE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECURITE_TYPEOPERATIONTRACE", x => x.CODETYPEOPERTRAC);
                });

            migrationBuilder.CreateTable(
                name: "Signalisation_Fichier",
                columns: table => new
                {
                    CodeFichier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeSignalisation = table.Column<int>(type: "int", nullable: true),
                    NomFichier = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signalisation_Fichier", x => x.CodeFichier);
                });

            migrationBuilder.CreateTable(
                name: "Signalisation_Fichier_Rpt",
                columns: table => new
                {
                    CodeFichier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeSignalisation = table.Column<int>(type: "int", nullable: true),
                    NomFichier = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signalisation_Fichier_Rpt", x => x.CodeFichier);
                });

            migrationBuilder.CreateTable(
                name: "Signalisation_NatureAnomalie",
                columns: table => new
                {
                    CodeSignalisation = table.Column<int>(type: "int", nullable: true),
                    CodeNatureAnomalie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Signature_Fichier",
                columns: table => new
                {
                    codeutil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fichier = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Gouvernorat",
                columns: table => new
                {
                    CodeGouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code gouvernorat"),
                    LibeGouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Libellé gouvernorat"),
                    CodeDist = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "District"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Gouvernorat", x => x.CodeGouv);
                    table.ForeignKey(
                        name: "FK_Nomenclature_Gouvernorat_Nomenclature_District",
                        column: x => x.CodeDist,
                        principalTable: "Nomenclature_District",
                        principalColumn: "CodeDist");
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Equipement",
                columns: table => new
                {
                    CodeEqui = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeEqui = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaraEqui = table.Column<string>(type: "nvarchar(max)", nullable: true, collation: "Arabic_CI_AS"),
                    CodeTypeEqui = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Equipement", x => x.CodeEqui);
                    table.ForeignKey(
                        name: "FK_Nomenclature_Equipement_Nomenclature_TypeEquipement",
                        column: x => x.CodeTypeEqui,
                        principalTable: "Nomenclature_TypeEquipement",
                        principalColumn: "CodeTypeEqui");
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_CaracteristiqueEspace",
                columns: table => new
                {
                    CodeCaraEspa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeCaraEspa = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true),
                    CodeTypeEspa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_CaracteristiqueEspace", x => x.CodeCaraEspa);
                    table.ForeignKey(
                        name: "FK_Nomenclature_CaracteristiqueEspace_Nomenclature_TypeEspace",
                        column: x => x.CodeTypeEspa,
                        principalTable: "Nomenclature_TypeEspace",
                        principalColumn: "CodeTypeEspa");
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_CategorieRubriqueInspection",
                columns: table => new
                {
                    CodeCateRubrInsp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeCateRubrInsp = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true),
                    CodeTypeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Code type établissement")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_CategorieRubriqueInspection", x => x.CodeCateRubrInsp);
                    table.ForeignKey(
                        name: "FK_Nomenclature_CategorieRubriqueInspection_Nomenclature_TypeEtablissement",
                        column: x => x.CodeTypeEtab,
                        principalTable: "Nomenclature_TypeEtablissement",
                        principalColumn: "CodeTypeEtab");
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_OrganisationAdministrative",
                columns: table => new
                {
                    CodeOrgaAdmi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Commune"),
                    LibeOrgaAdmi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true),
                    CodeTypeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Code type établissement")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_OrganisationAdministrative", x => x.CodeOrgaAdmi);
                    table.ForeignKey(
                        name: "FK_Nomenclature_OrganisationAdministrative_Nomenclature_TypeEtablissement",
                        column: x => x.CodeTypeEtab,
                        principalTable: "Nomenclature_TypeEtablissement",
                        principalColumn: "CodeTypeEtab");
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_OrganisationPedagogique",
                columns: table => new
                {
                    CodeOrgaPeda = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Commune"),
                    LibeOrgaPeda = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true),
                    CodeTypeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Code type établissement")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_OrganisationPedagogique", x => x.CodeOrgaPeda);
                    table.ForeignKey(
                        name: "FK_Nomenclature_OrganisationPedagogique_Nomenclature_TypeEtablissement",
                        column: x => x.CodeTypeEtab,
                        principalTable: "Nomenclature_TypeEtablissement",
                        principalColumn: "CodeTypeEtab");
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_EtatEtablissement",
                columns: table => new
                {
                    CodeEtatEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code type établissement"),
                    LibeEtatEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Libellé type établissement (Arabe)"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)"),
                    CodeTypeEtatEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_EtatEtablissement", x => x.CodeEtatEtab);
                    table.ForeignKey(
                        name: "FK__Nomenclat__CodeT__3A8CA01F",
                        column: x => x.CodeTypeEtatEtab,
                        principalTable: "Nomenclature_TypeEtatEtablissement",
                        principalColumn: "CodeTypeEtatEtab");
                });

            migrationBuilder.CreateTable(
                name: "Inspection_VisiteInspection",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    MatrInsp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateVisiInsp = table.Column<DateTime>(type: "date", nullable: true),
                    CodeTypeInsp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeduGene = table.Column<string>(type: "nvarchar(max)", nullable: true, collation: "Arabic_CI_AS"),
                    CodeEtabPers = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AnneScolPers = table.Column<int>(type: "int", nullable: true),
                    IdenUniqPers = table.Column<int>(type: "int", nullable: true),
                    DateProcVisi = table.Column<DateTime>(type: "date", nullable: true),
                    Note = table.Column<double>(type: "float", nullable: true),
                    NoteEnLettre = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    RemaSuiv_Sujet = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RemaSuiv_Pers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemaSuiv_Infr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemaSuiv_Acti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemaSuiv_CondSecu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemaSuiv_ProgPeda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombEnfaInscMasc = table.Column<int>(type: "int", nullable: true),
                    NombEnfaInscFemi = table.Column<int>(type: "int", nullable: true),
                    NombEnfaPresMasc = table.Column<int>(type: "int", nullable: true),
                    NombEnfaPresFemi = table.Column<int>(type: "int", nullable: true),
                    VisiPerSuivActi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JustDeciFerm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateLimiCorr = table.Column<int>(type: "int", nullable: true),
                    MembCommTitu = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DetaAnom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datesaisie = table.Column<DateTime>(type: "date", nullable: true),
                    CodeEtatEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RemarqueInsp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Statut = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    inspecteurvalide = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datevalidation = table.Column<DateTime>(type: "datetime", nullable: true),
                    chefvue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datevue = table.Column<DateTime>(type: "datetime", nullable: true),
                    capacite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datemail = table.Column<DateTime>(type: "datetime", nullable: true),
                    Inspecteur2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeActivite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PriseRemaq = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "((0))"),
                    datedemandeMAJ = table.Column<DateTime>(type: "date", nullable: true),
                    dateconfirmationMAJ = table.Column<DateTime>(type: "date", nullable: true),
                    codeutilConfirmation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DemandeMAJ = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    MotifMAJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinSaisie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_VisiteInspection", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol });
                    table.ForeignKey(
                        name: "FK_Inspection_VisiteInspection_Nomenclature_TypeInspection",
                        column: x => x.CodeTypeInsp,
                        principalTable: "Nomenclature_TypeInspection",
                        principalColumn: "CodeTypeInsp");
                });

            migrationBuilder.CreateTable(
                name: "Message_Message",
                columns: table => new
                {
                    idMessage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateEnvoi = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodeTypeM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodeUtilFrom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<bool>(type: "bit", nullable: true),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnneScol = table.Column<int>(type: "int", nullable: true),
                    Idmessage_Parent = table.Column<int>(type: "int", nullable: true),
                    codeutil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message_Message", x => x.idMessage);
                    table.ForeignKey(
                        name: "FK_Message_Message_Nomenclature_TypeMessage",
                        column: x => x.CodeTypeM,
                        principalTable: "Nomenclature_TypeMessage",
                        principalColumn: "CodeTypeM");
                });

            migrationBuilder.CreateTable(
                name: "Parametrage_Columns",
                columns: table => new
                {
                    NumeNome = table.Column<int>(type: "int", nullable: false),
                    NumeColu = table.Column<int>(type: "int", nullable: false),
                    ColuName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ForeKeys = table.Column<bool>(type: "bit", nullable: true),
                    NomTable = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LibeNome = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CodeEnti = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TypeRela = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LibeColu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametrage_FkColumns", x => new { x.NumeNome, x.NumeColu });
                    table.ForeignKey(
                        name: "FK_Parametrage_FkColumns_Parametrage_Nomenclature",
                        column: x => x.NumeNome,
                        principalTable: "Parametrage_Nomenclature",
                        principalColumn: "NumeNome");
                });

            migrationBuilder.CreateTable(
                name: "SECURITE_UTILISATEUR",
                columns: table => new
                {
                    CODEUTIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Code commerciale (Login)"),
                    MOTPASSUTIL = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Mot de passe"),
                    MATR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Matricule"),
                    NOMPRENUTIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Nom et prénom"),
                    Tele = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Téléphone / GSM"),
                    GSM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SkypeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CODEGROUUTIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Groupe utilisateur"),
                    CODENIVEHIER = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Niveau hierarchique"),
                    DATEMAJ = table.Column<DateTime>(type: "datetime", nullable: true, comment: "Date de dernier MAJ"),
                    CodeCommFonc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Code type standing"),
                    Etat = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    CodeGouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeUtilPare = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    codeutiladd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dateadduser = table.Column<DateTime>(type: "datetime", nullable: true),
                    codeutilupdate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dateupdateuser = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodeCerc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECURITE_UTILISATEUR", x => x.CODEUTIL);
                    table.ForeignKey(
                        name: "FK_SECURITE_UTILISATEUR_SECURI",
                        column: x => x.CODENIVEHIER,
                        principalTable: "SECURITE_NIVEAUHIERARCHIQUE",
                        principalColumn: "CODENIVEHIER");
                    table.ForeignKey(
                        name: "FK_SECURITE_UTILISATEUR_SECURT",
                        column: x => x.CODEGROUUTIL,
                        principalTable: "SECURITE_GROUPEUTILISATEUR",
                        principalColumn: "CODEGROUUTIL");
                });

            migrationBuilder.CreateTable(
                name: "SECURITE_ENTITE",
                columns: table => new
                {
                    CODEENTI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LIBEENTI = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CODEPACK = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CODERANGMENU = table.Column<int>(type: "int", nullable: true),
                    URI = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECURITE_ENTITE", x => x.CODEENTI);
                    table.ForeignKey(
                        name: "FK_SECURITE_ENTITE_SECURITE_PA",
                        column: x => x.CODEPACK,
                        principalTable: "SECURITE_PACKAGE",
                        principalColumn: "CODEPACK");
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Delegation",
                columns: table => new
                {
                    CodeDele = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code délégation"),
                    LibeDele = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Libellé délégation"),
                    CodeGouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Code gouvernorat"),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true, comment: "Order d'affichage"),
                    Acti = table.Column<bool>(type: "bit", nullable: true, comment: "Actif (Oui/Non)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Delegation", x => x.CodeDele);
                    table.ForeignKey(
                        name: "FK_Nomenclature_Delegation_Nomenclature_Gouvernorat",
                        column: x => x.CodeGouv,
                        principalTable: "Nomenclature_Gouvernorat",
                        principalColumn: "CodeGouv");
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_CategorieRubriqueTypeInspection",
                columns: table => new
                {
                    CodeTypeInsp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodeCateRubrInsp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_CategorieRubriqueTypeInspection", x => new { x.CodeTypeInsp, x.CodeCateRubrInsp });
                    table.ForeignKey(
                        name: "FK_Nomenclature_CategorieRubriqueTypeInspection_Nomenclature_CategorieRubriqueInspection",
                        column: x => x.CodeCateRubrInsp,
                        principalTable: "Nomenclature_CategorieRubriqueInspection",
                        principalColumn: "CodeCateRubrInsp");
                    table.ForeignKey(
                        name: "FK_Nomenclature_CategorieRubriqueTypeInspection_Nomenclature_TypeInspection",
                        column: x => x.CodeTypeInsp,
                        principalTable: "Nomenclature_TypeInspection",
                        principalColumn: "CodeTypeInsp");
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_RubriqueInspection",
                columns: table => new
                {
                    CodeRubrInsp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LibeRubrInsp = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CodeCateRubrInsp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrdrAffi = table.Column<int>(type: "int", nullable: true),
                    Acti = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_RubriqueInspection1", x => x.CodeRubrInsp);
                    table.ForeignKey(
                        name: "FK_Nomenclature_RubriqueInspection_Nomenclature_CategorieRubriqueInspection",
                        column: x => x.CodeCateRubrInsp,
                        principalTable: "Nomenclature_CategorieRubriqueInspection",
                        principalColumn: "CodeCateRubrInsp");
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_OrganisationAdministrative",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeOrgaAdmi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Commune"),
                    Disp = table.Column<bool>(type: "bit", nullable: false),
                    AJour = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_OrganisationAdministrative", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.CodeOrgaAdmi });
                    table.ForeignKey(
                        name: "FK_Etablissement_OrganisationAdministrative_Nomenclature_OrganisationAdministrative",
                        column: x => x.CodeOrgaAdmi,
                        principalTable: "Nomenclature_OrganisationAdministrative",
                        principalColumn: "CodeOrgaAdmi");
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_OrganisationPedagogique",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeOrgaPeda = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Commune"),
                    Disp = table.Column<bool>(type: "bit", nullable: false),
                    AJour = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_OrganisationPedagogique_1", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.CodeOrgaPeda });
                    table.ForeignKey(
                        name: "FK_Etablissement_OrganisationPedagogique_Nomenclature_OrganisationPedagogique",
                        column: x => x.CodeOrgaPeda,
                        principalTable: "Nomenclature_OrganisationPedagogique",
                        principalColumn: "CodeOrgaPeda");
                });

            migrationBuilder.CreateTable(
                name: "Inspection_Anomalie",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeAnom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Commune")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_Anomalie", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.CodeAnom });
                    table.ForeignKey(
                        name: "FK_Inspection_Anomalie_Inspection_VisiteInspection",
                        columns: x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol },
                        principalTable: "Inspection_VisiteInspection",
                        principalColumns: new[] { "NumeVisiInsp", "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspection_Anomalie_Nomenclature_Anomalie",
                        column: x => x.CodeAnom,
                        principalTable: "Nomenclature_Anomalie",
                        principalColumn: "CodeAnom");
                });

            migrationBuilder.CreateTable(
                name: "Inspection_DeductionCategorieRubriqueInspection",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeCateRubrInsp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Dedu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_DeductionCategorieRubriqueInspection", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.CodeCateRubrInsp });
                    table.ForeignKey(
                        name: "FK_Inspection_DeductionCategorieRubriqueInspection_Inspection_VisiteInspection",
                        columns: x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol },
                        principalTable: "Inspection_VisiteInspection",
                        principalColumns: new[] { "NumeVisiInsp", "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspection_DeductionCategorieRubriqueInspection_Nomenclature_CategorieRubriqueInspection",
                        column: x => x.CodeCateRubrInsp,
                        principalTable: "Nomenclature_CategorieRubriqueInspection",
                        principalColumn: "CodeCateRubrInsp");
                });

            migrationBuilder.CreateTable(
                name: "Inspection_Equipement",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    NumeEqui = table.Column<long>(type: "bigint", nullable: false),
                    LibeTypeEqui = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ConfCara = table.Column<bool>(type: "bit", nullable: true),
                    Disp = table.Column<bool>(type: "bit", nullable: true),
                    Obse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_Equipement", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.NumeEqui });
                    table.ForeignKey(
                        name: "FK_Inspection_Equipement_Inspection_VisiteInspection",
                        columns: x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol },
                        principalTable: "Inspection_VisiteInspection",
                        principalColumns: new[] { "NumeVisiInsp", "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inspection_espace",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    NumeEspa = table.Column<int>(type: "int", nullable: false),
                    LibeTypeEspa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surf = table.Column<double>(type: "float", nullable: true),
                    Haut = table.Column<double>(type: "float", nullable: true),
                    Obse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfCara = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_espace", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.NumeEspa });
                    table.ForeignKey(
                        name: "FK_Inspection_espace_Inspection_VisiteInspection",
                        columns: x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol },
                        principalTable: "Inspection_VisiteInspection",
                        principalColumns: new[] { "NumeVisiInsp", "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inspection_InfoGenerale",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    LibeEtab = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LibeTypeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LibeDele = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LibeGouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodePost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdreEtab = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TeleFixe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LibeComm = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NomPrenFond = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumePiecIden = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateDepoCahiChar = table.Column<DateTime>(type: "datetime", nullable: true),
                    DepoCahiCharPrep = table.Column<bool>(type: "bit", nullable: false),
                    DateCrea = table.Column<DateTime>(type: "datetime", nullable: true),
                    NomPrenDire = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NumePiecIdenDire = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_InfoGenerale", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol });
                    table.ForeignKey(
                        name: "FK_Inspection_InfoGenerale_Inspection_VisiteInspection",
                        columns: x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol },
                        principalTable: "Inspection_VisiteInspection",
                        principalColumns: new[] { "NumeVisiInsp", "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inspection_Infrastructure",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    LibeEmplSieg = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AutrEmplSieg = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CodeEmplSieg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LibeTypeProp = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SurfTota = table.Column<double>(type: "float", nullable: true),
                    SurfBati = table.Column<double>(type: "float", nullable: true),
                    SurfEspaExte = table.Column<double>(type: "float", nullable: true),
                    LibeTypeClot = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Clot = table.Column<bool>(type: "bit", nullable: true),
                    HautClot = table.Column<double>(type: "float", nullable: true),
                    PassSpecPersBesoSpec = table.Column<bool>(type: "bit", nullable: true),
                    TeleFixe = table.Column<bool>(type: "bit", nullable: true),
                    LibeTypeConnInte = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LibeCaraEspaExte = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LibeEmpl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    existTerrain = table.Column<bool>(type: "bit", nullable: true),
                    SurfaceTerrain = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LibeTerrain = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Inspection_Infrastructure_Inspection_VisiteInspection",
                        columns: x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol },
                        principalTable: "Inspection_VisiteInspection",
                        principalColumns: new[] { "NumeVisiInsp", "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inspection_NombreEnfantTrancheAge",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeTranAge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombEnfa = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_NombreEnfantTrancheAge", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.CodeTranAge });
                    table.ForeignKey(
                        name: "FK_Inspection_NombreEnfantTrancheAge_Inspection_VisiteInspection",
                        columns: x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol },
                        principalTable: "Inspection_VisiteInspection",
                        principalColumns: new[] { "NumeVisiInsp", "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspection_NombreEnfantTrancheAge_Nomenclature_TrancheAge",
                        column: x => x.CodeTranAge,
                        principalTable: "Nomenclature_TrancheAge",
                        principalColumn: "CodeTranAge");
                });

            migrationBuilder.CreateTable(
                name: "Inspection_Recifications",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeRect = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Etat = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_Recifications", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.CodeRect });
                    table.ForeignKey(
                        name: "FK_Inspection_Recifications_Inspection_VisiteInspection",
                        columns: x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol },
                        principalTable: "Inspection_VisiteInspection",
                        principalColumns: new[] { "NumeVisiInsp", "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspection_Recifications_Nomenclature_rectification",
                        column: x => x.CodeRect,
                        principalTable: "Nomenclature_rectification",
                        principalColumn: "CodeRect");
                });

            migrationBuilder.CreateTable(
                name: "Inspection_RepartitionHandicap",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    LibeTypeHand = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NombMasc = table.Column<int>(type: "int", nullable: true),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombTota = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_RepartitionHandicap", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.LibeTypeHand });
                    table.ForeignKey(
                        name: "FK_Inspection_RepartitionHandicap_Inspection_VisiteInspection",
                        columns: x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol },
                        principalTable: "Inspection_VisiteInspection",
                        principalColumns: new[] { "NumeVisiInsp", "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inspection_RepartitionPersonelFonction",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    LibeFonc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombMasc = table.Column<int>(type: "int", nullable: true),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombTota = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_RepartitionPersonelFonction", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.LibeFonc });
                    table.ForeignKey(
                        name: "FK_Inspection_RepartitionPersonelFonction_Inspection_VisiteInspection",
                        columns: x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol },
                        principalTable: "Inspection_VisiteInspection",
                        principalColumns: new[] { "NumeVisiInsp", "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inspection_RepartitionTrancheAge",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    LibeTranAge = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true),
                    NombTota = table.Column<int>(type: "int", nullable: true),
                    CodeTranAge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_RepartitionTrancheAge", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.LibeTranAge });
                    table.ForeignKey(
                        name: "FK_Inspection_RepartitionTrancheAge_Inspection_VisiteInspection",
                        columns: x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol },
                        principalTable: "Inspection_VisiteInspection",
                        principalColumns: new[] { "NumeVisiInsp", "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Message_Fichier",
                columns: table => new
                {
                    idMessage = table.Column<int>(type: "int", nullable: false),
                    nomfichier = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    extension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fichier = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Message_Fichier_Message_Message",
                        column: x => x.idMessage,
                        principalTable: "Message_Message",
                        principalColumn: "idMessage");
                });

            migrationBuilder.CreateTable(
                name: "Message_Groupe",
                columns: table => new
                {
                    idMessage = table.Column<int>(type: "int", nullable: false),
                    CodeGroup = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodeGouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Message_Groupe_Message_Message",
                        column: x => x.idMessage,
                        principalTable: "Message_Message",
                        principalColumn: "idMessage");
                });

            migrationBuilder.CreateTable(
                name: "Message_User",
                columns: table => new
                {
                    idMessage = table.Column<int>(type: "int", nullable: false),
                    CodeUtil = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Datereception = table.Column<DateTime>(type: "datetime", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lu = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message_User", x => new { x.idMessage, x.CodeUtil });
                    table.ForeignKey(
                        name: "FK_Message_User_Message_Message",
                        column: x => x.idMessage,
                        principalTable: "Message_Message",
                        principalColumn: "idMessage");
                });

            migrationBuilder.CreateTable(
                name: "Securite_SessionUtilisateur",
                columns: table => new
                {
                    CodeUtil = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateCurrSess = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateDebuLastSess = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateFinLastSess = table.Column<DateTime>(type: "datetime", nullable: true),
                    IpAdre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastIpAdre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Securite_SessionUtilisateur_1", x => x.CodeUtil);
                    table.ForeignKey(
                        name: "FK_Securite_SessionUtilisateur_SECURITE_UTILISATEUR",
                        column: x => x.CodeUtil,
                        principalTable: "SECURITE_UTILISATEUR",
                        principalColumn: "CODEUTIL");
                });

            migrationBuilder.CreateTable(
                name: "SECURITE_TRACEUTILISATEUR",
                columns: table => new
                {
                    NUMETRAC = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LIBETRAC = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    LINKTRAC = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CODEUTIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DATETRAC = table.Column<DateTime>(type: "datetime", nullable: false),
                    CODETYPEOPER = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CODEENTI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PKENTI = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECURITE_TRACEUTILISATEUR", x => x.NUMETRAC);
                    table.ForeignKey(
                        name: "FK_SECURITE_TRACEUTILISATEUR_S",
                        column: x => x.CODEUTIL,
                        principalTable: "SECURITE_UTILISATEUR",
                        principalColumn: "CODEUTIL");
                    table.ForeignKey(
                        name: "FK_SECURITE_TRACEUTILISATEUR_SECURITE_TYPEOPERATIONTRACE",
                        column: x => x.CODETYPEOPER,
                        principalTable: "SECURITE_TYPEOPERATIONTRACE",
                        principalColumn: "CODETYPEOPERTRAC");
                });

            migrationBuilder.CreateTable(
                name: "SECURITE_DROITACCESGROUPE",
                columns: table => new
                {
                    CODEGROUUTIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CODEENTI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DroiSele = table.Column<bool>(type: "bit", nullable: false),
                    DroiUpda = table.Column<bool>(type: "bit", nullable: false),
                    DroiDele = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECURITE_DROITACCESGROUPE", x => new { x.CODEGROUUTIL, x.CODEENTI });
                    table.ForeignKey(
                        name: "FK_SECURITE_DROITACCESGROUP_26",
                        column: x => x.CODEGROUUTIL,
                        principalTable: "SECURITE_GROUPEUTILISATEUR",
                        principalColumn: "CODEGROUUTIL");
                    table.ForeignKey(
                        name: "FK_SECURITE_DROITACCESGROUPE_S",
                        column: x => x.CODEENTI,
                        principalTable: "SECURITE_ENTITE",
                        principalColumn: "CODEENTI");
                });

            migrationBuilder.CreateTable(
                name: "SECURITE_DROITACCESUTILISATEUR",
                columns: table => new
                {
                    CODEENTI = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CODEUTIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DroiAcce = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECURITE_DROITACCESUTILISAT", x => new { x.CODEENTI, x.CODEUTIL });
                    table.ForeignKey(
                        name: "FK_SECURITE_DROITACCESUTILI_26",
                        column: x => x.CODEUTIL,
                        principalTable: "SECURITE_UTILISATEUR",
                        principalColumn: "CODEUTIL");
                    table.ForeignKey(
                        name: "FK_SECURITE_DROITACCESUTILISAT",
                        column: x => x.CODEENTI,
                        principalTable: "SECURITE_ENTITE",
                        principalColumn: "CODEENTI");
                });

            migrationBuilder.CreateTable(
                name: "ENFANT_necessite",
                columns: table => new
                {
                    idenfant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateNais = table.Column<DateTime>(type: "date", nullable: true),
                    nomprenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LieuNais = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeGenr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EtatSante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nompere = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    codenatPere = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumeCIN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Profession = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeComm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeDele = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdrePers = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CodePost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EtatFamille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeTypeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeDeleEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeCommEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Anniscription = table.Column<int>(type: "int", nullable: true),
                    NbAnne = table.Column<int>(type: "int", nullable: true),
                    CodeutilADD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateAjout = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodeutilUpdate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dateupdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodeutilSup = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Datesup = table.Column<DateTime>(type: "datetime", nullable: true),
                    Activ = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Famille_necessite", x => x.idenfant);
                    table.ForeignKey(
                        name: "FK_ENFANT_necessite_Nomenclature_Commune",
                        column: x => x.CodeComm,
                        principalTable: "Nomenclature_Commune",
                        principalColumn: "CodeComm");
                    table.ForeignKey(
                        name: "FK_ENFANT_necessite_Nomenclature_Delegation",
                        column: x => x.CodeDele,
                        principalTable: "Nomenclature_Delegation",
                        principalColumn: "CodeDele");
                    table.ForeignKey(
                        name: "FK_ENFANT_necessite_Nomenclature_TypeEtablissement",
                        column: x => x.CodeTypeEtab,
                        principalTable: "Nomenclature_TypeEtablissement",
                        principalColumn: "CodeTypeEtab");
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Etablissement",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    LibeEtab = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "Libellé établissement"),
                    CodeTypeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Type établissement"),
                    MatrFisc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeSect = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Secteur"),
                    CodeZoneHabi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Zone habitation"),
                    CodeDele = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Délégation"),
                    CodeCommEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumeDeciOuve = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Numéro du décision d'ouverture"),
                    DateDemaActi = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())", comment: "La date du démarage de l'activité"),
                    DateDeciOuve = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())", comment: "Date du décision d'ouverture"),
                    DateDepoCahiChar = table.Column<DateTime>(type: "datetime", nullable: true, comment: "La date dépôt du cahier des charges"),
                    DepoCahiCharPrep = table.Column<bool>(type: "bit", nullable: false),
                    DateCrea = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())", comment: "Date de création"),
                    DateCreaBD = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())", comment: "Date de création"),
                    NomPrenFond = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Nom et Prénom du fondateur de projet"),
                    CodeGenrFond = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Genre"),
                    NumePiecIden = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "CIN"),
                    DateDeliv = table.Column<DateTime>(type: "datetime", nullable: true, comment: "Date de délivrance CIN"),
                    DateNaisFond = table.Column<DateTime>(type: "datetime", nullable: true, comment: "Date de naissance fondateur"),
                    LieuNaisFond = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Lieu de naissance fondateur"),
                    AdrePersFond = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, comment: "Adresse personnel fondateur"),
                    CodePostFond = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Code postale"),
                    CodeDeleFond = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Délégation fondateur"),
                    CodeComm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Commune"),
                    CodeNiveEtud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Code Niveau d'Etude"),
                    CodeDipl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Diplome"),
                    CodeSituFami = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Code genre"),
                    NombEnfa = table.Column<int>(type: "int", nullable: true, comment: "Nombre d'enfant"),
                    Prof = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, comment: "Profession"),
                    Tele = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true, comment: "Téléphone"),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, comment: "E-mail"),
                    NumeEtab = table.Column<int>(type: "int", nullable: true),
                    CodeEtatEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdreEtab = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CodePostEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeMiniFond = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateFerm = table.Column<DateTime>(type: "datetime", nullable: true),
                    CausFerm = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UserFerm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateVAlFerm = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Etablissement_1", x => x.CodeEtab);
                    table.ForeignKey(
                        name: "FK_Nomenclature_Etablissement_Nomenclature_Commune",
                        column: x => x.CodeComm,
                        principalTable: "Nomenclature_Commune",
                        principalColumn: "CodeComm");
                    table.ForeignKey(
                        name: "FK_Nomenclature_Etablissement_Nomenclature_Delegation",
                        column: x => x.CodeDele,
                        principalTable: "Nomenclature_Delegation",
                        principalColumn: "CodeDele");
                    table.ForeignKey(
                        name: "FK_Nomenclature_Etablissement_Nomenclature_Delegation1",
                        column: x => x.CodeDeleFond,
                        principalTable: "Nomenclature_Delegation",
                        principalColumn: "CodeDele");
                    table.ForeignKey(
                        name: "FK_Nomenclature_Etablissement_Nomenclature_Diplome",
                        column: x => x.CodeDipl,
                        principalTable: "Nomenclature_Diplome",
                        principalColumn: "CodeDipl");
                    table.ForeignKey(
                        name: "FK_Nomenclature_Etablissement_Nomenclature_NiveauEtude",
                        column: x => x.CodeNiveEtud,
                        principalTable: "Nomenclature_NiveauEtude",
                        principalColumn: "CodeNiveEtud");
                    table.ForeignKey(
                        name: "FK_Nomenclature_Etablissement_Nomenclature_Secteur",
                        column: x => x.CodeSect,
                        principalTable: "Nomenclature_Secteur",
                        principalColumn: "CodeSect");
                    table.ForeignKey(
                        name: "FK_Nomenclature_Etablissement_Nomenclature_SituationFamiliale",
                        column: x => x.CodeSituFami,
                        principalTable: "Nomenclature_SituationFamiliale",
                        principalColumn: "CodeSituFami");
                    table.ForeignKey(
                        name: "FK_Nomenclature_Etablissement_Nomenclature_TypeEtablissement",
                        column: x => x.CodeTypeEtab,
                        principalTable: "Nomenclature_TypeEtablissement",
                        principalColumn: "CodeTypeEtab");
                    table.ForeignKey(
                        name: "FK_Nomenclature_Etablissement_Nomenclature_Zone",
                        column: x => x.CodeZoneHabi,
                        principalTable: "Nomenclature_Zone",
                        principalColumn: "CodeZone");
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_Signalisation",
                columns: table => new
                {
                    CodeSignalisation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomInformateur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeTypeSignalisation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateCreation = table.Column<DateTime>(type: "date", nullable: true),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomConcerne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresseConcerne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeConcerne = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeInformateur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VilleConcerne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Etablissement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fichier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeGouv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeDele = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateSignalisation = table.Column<DateTime>(type: "date", nullable: true),
                    MethodeSignalisation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateDepot = table.Column<DateTime>(type: "date", nullable: true),
                    NumeroDepot = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TypeSignalisation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChefService = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeInspecteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeResponsable = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateChefService = table.Column<DateTime>(type: "date", nullable: true),
                    DateInfoInspecteur = table.Column<DateTime>(type: "date", nullable: true),
                    DateAnalyse = table.Column<DateTime>(type: "date", nullable: true),
                    TextAnalyse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCloture = table.Column<DateTime>(type: "date", nullable: true),
                    CodeStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ObservationChefService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResultatChefService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeEtablissement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AnneScol = table.Column<int>(type: "int", nullable: true),
                    acti = table.Column<bool>(type: "bit", nullable: true),
                    MotifSupression = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Inspecteur2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datecreationrapport = table.Column<DateTime>(type: "datetime", nullable: true),
                    datevisite = table.Column<DateTime>(type: "date", nullable: true),
                    conusltatEnfance = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_Signalisation", x => x.CodeSignalisation);
                    table.ForeignKey(
                        name: "FK_Nomenclature_Signalisation_Nomenclature_Concerne",
                        column: x => x.CodeConcerne,
                        principalTable: "Nomenclature_Concerne",
                        principalColumn: "CodeConcerne");
                    table.ForeignKey(
                        name: "FK_Nomenclature_Signalisation_Nomenclature_Delegation",
                        column: x => x.CodeDele,
                        principalTable: "Nomenclature_Delegation",
                        principalColumn: "CodeDele");
                    table.ForeignKey(
                        name: "FK_Nomenclature_Signalisation_Nomenclature_Gouve",
                        column: x => x.CodeGouv,
                        principalTable: "Nomenclature_Gouvernorat",
                        principalColumn: "CodeGouv");
                    table.ForeignKey(
                        name: "FK_Nomenclature_Signalisation_Nomenclature_Informateur",
                        column: x => x.CodeInformateur,
                        principalTable: "Nomenclature_Informateur",
                        principalColumn: "CodeInformateur");
                    table.ForeignKey(
                        name: "FK_Nomenclature_Signalisation_Nomenclature_TypeSignalisation",
                        column: x => x.CodeTypeSignalisation,
                        principalTable: "Nomenclature_TypeSignalisation",
                        principalColumn: "CodeTypeSignalisation");
                });

            migrationBuilder.CreateTable(
                name: "Personnel_Personnel",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    IdenUniq = table.Column<int>(type: "int", nullable: false),
                    IdenUniqMatrCnss = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NomPren = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "NomPren"),
                    CodeGenr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateNais = table.Column<DateTime>(type: "datetime", nullable: true),
                    LieuNais = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumeCIN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DateCIN = table.Column<DateTime>(type: "datetime", nullable: true),
                    CodeNiveEtud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Niveau d'Etude"),
                    CodeDipl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Spécialité"),
                    CodeSituFami = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Situation familiale"),
                    AdrePers = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CodePost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeDele = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Délégation"),
                    CodeGrad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Grade"),
                    CodeQual = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Code qualité"),
                    CodeFonc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Code Fonction"),
                    Anci = table.Column<double>(type: "float", nullable: true, comment: "Anciennete (Année)"),
                    CodeCorp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Code corps"),
                    Spec = table.Column<bool>(type: "bit", nullable: true, comment: "Spécialiste"),
                    Elig = table.Column<bool>(type: "bit", nullable: true, comment: "Eligible"),
                    CodeReveMens = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Code genre"),
                    CompInfo = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Complément information"),
                    CodeSituProf = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TelGSM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StructureAttache = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    daterecrutement = table.Column<DateTime>(type: "date", nullable: true),
                    dateaffectation = table.Column<DateTime>(type: "date", nullable: true),
                    daterespons = table.Column<DateTime>(type: "date", nullable: true),
                    notePead = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datenotePead = table.Column<DateTime>(type: "date", nullable: true),
                    AnotePead = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdatenotePead = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnel_Personnel", x => new { x.CodeEtab, x.AnneScol, x.IdenUniq });
                    table.ForeignKey(
                        name: "FK__Personnel__CodeS__2779CBAB",
                        column: x => x.CodeSituProf,
                        principalTable: "Nomenclature_SituationProfessionel",
                        principalColumn: "CodeSituProf");
                    table.ForeignKey(
                        name: "FK_Personnel_Personnel_Nomenclature_Corps",
                        column: x => x.CodeCorp,
                        principalTable: "Nomenclature_Corps",
                        principalColumn: "CodeCorp");
                    table.ForeignKey(
                        name: "FK_Personnel_Personnel_Nomenclature_Delegation",
                        column: x => x.CodeDele,
                        principalTable: "Nomenclature_Delegation",
                        principalColumn: "CodeDele");
                    table.ForeignKey(
                        name: "FK_Personnel_Personnel_Nomenclature_Diplome",
                        column: x => x.CodeDipl,
                        principalTable: "Nomenclature_Diplome",
                        principalColumn: "CodeDipl");
                    table.ForeignKey(
                        name: "FK_Personnel_Personnel_Nomenclature_Fonction",
                        column: x => x.CodeFonc,
                        principalTable: "Nomenclature_Fonction",
                        principalColumn: "CodeFonc");
                    table.ForeignKey(
                        name: "FK_Personnel_Personnel_Nomenclature_Genre",
                        column: x => x.CodeGenr,
                        principalTable: "Nomenclature_Genre",
                        principalColumn: "CodeGenr");
                    table.ForeignKey(
                        name: "FK_Personnel_Personnel_Nomenclature_Grade",
                        column: x => x.CodeGrad,
                        principalTable: "Nomenclature_Grade",
                        principalColumn: "CodeGrad");
                    table.ForeignKey(
                        name: "FK_Personnel_Personnel_Nomenclature_NiveauEtude",
                        column: x => x.CodeNiveEtud,
                        principalTable: "Nomenclature_NiveauEtude",
                        principalColumn: "CodeNiveEtud");
                    table.ForeignKey(
                        name: "FK_Personnel_Personnel_Nomenclature_Qualite",
                        column: x => x.CodeQual,
                        principalTable: "Nomenclature_Qualite",
                        principalColumn: "CodeQual");
                    table.ForeignKey(
                        name: "FK_Personnel_Personnel_Nomenclature_RevenuMensuel",
                        column: x => x.CodeReveMens,
                        principalTable: "Nomenclature_RevenuMensuel",
                        principalColumn: "CodeReveMens");
                });

            migrationBuilder.CreateTable(
                name: "Inspection_Constatation",
                columns: table => new
                {
                    NumeVisiInsp = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeRubrInsp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodeCons = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Obse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection_Constatation", x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol, x.CodeRubrInsp });
                    table.ForeignKey(
                        name: "FK_Inspection_Constatation_Inspection_VisiteInspection",
                        columns: x => new { x.NumeVisiInsp, x.CodeEtab, x.AnneScol },
                        principalTable: "Inspection_VisiteInspection",
                        principalColumns: new[] { "NumeVisiInsp", "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspection_Constatation_Nomenclature_RubriqueInspection",
                        column: x => x.CodeRubrInsp,
                        principalTable: "Nomenclature_RubriqueInspection",
                        principalColumn: "CodeRubrInsp");
                });

            migrationBuilder.CreateTable(
                name: "Nomenclature_ConstatationRubriqueInspection",
                columns: table => new
                {
                    CodeRubrInsp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodeCons = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nomenclature_ConstatationRubriqueInspection", x => new { x.CodeRubrInsp, x.CodeCons });
                    table.ForeignKey(
                        name: "FK_Nomenclature_ConstatationRubriqueInspection_Nomenclature_Constatation",
                        column: x => x.CodeCons,
                        principalTable: "Nomenclature_Constatation",
                        principalColumn: "CodeCons");
                    table.ForeignKey(
                        name: "FK_Nomenclature_ConstatationRubriqueInspection_Nomenclature_RubriqueInspection",
                        column: x => x.CodeRubrInsp,
                        principalTable: "Nomenclature_RubriqueInspection",
                        principalColumn: "CodeRubrInsp");
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_FicheEtablissement",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    AdreEtab = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Adresse de l'établissement"),
                    CodePost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Code postal"),
                    CodeDele = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeComm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TeleFixe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Téléphone fixe"),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Fax"),
                    EMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Adresse électronique"),
                    SiteWeb = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "Site web"),
                    CodePersDire = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Directeur de l'établissement"),
                    CodeOuveEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FraiInscParAnne = table.Column<double>(type: "float", nullable: true, comment: "Frais inscription par année"),
                    FraiMensActiNorm = table.Column<double>(type: "float", nullable: true, comment: "Frais mensuel de l'activité normale"),
                    FraiMensPepi = table.Column<double>(type: "float", nullable: true, comment: "Frais mensuel de l'activité normale"),
                    FraiMesuCont = table.Column<double>(type: "float", nullable: true, comment: "Frais mensuel de l'activité normale"),
                    capacite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HeureDebutS1 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    HeureFinS1 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    HeureDebutS2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    HeureFinS2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CreationEtatb = table.Column<bool>(type: "bit", nullable: true),
                    ChangementAdresse = table.Column<bool>(type: "bit", nullable: true),
                    ChangementDitecteur = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_FicheEtablissement_1", x => new { x.CodeEtab, x.AnneScol });
                    table.ForeignKey(
                        name: "FK_Etablissement_FicheEtablissement_Nomenclature_Delegation",
                        column: x => x.CodeDele,
                        principalTable: "Nomenclature_Delegation",
                        principalColumn: "CodeDele");
                    table.ForeignKey(
                        name: "FK_Etablissement_FicheEtablissement_Nomenclature_Etablissement",
                        column: x => x.CodeEtab,
                        principalTable: "Nomenclature_Etablissement",
                        principalColumn: "CodeEtab",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etablissement_FicheEtablissement_Nomenclature_OuvertureEtablissement",
                        column: x => x.CodeOuveEtab,
                        principalTable: "Nomenclature_OuvertureEtablissement",
                        principalColumn: "CodeOuveEtab");
                });

            migrationBuilder.CreateTable(
                name: "Reclamation_ReclamationParent",
                columns: table => new
                {
                    NumeRecl = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NomPren = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CIN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Tele = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateRecl = table.Column<DateTime>(type: "datetime", nullable: false),
                    Sujet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeEtatRecl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodePrio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rapp = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ObseDeci = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODEUTIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Code commerciale (Login)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reclamation_ReclamationParent", x => x.NumeRecl);
                    table.ForeignKey(
                        name: "FK_Reclamation_ReclamationParent_Nomenclature_Etablissement",
                        column: x => x.CodeEtab,
                        principalTable: "Nomenclature_Etablissement",
                        principalColumn: "CodeEtab");
                    table.ForeignKey(
                        name: "FK_Reclamation_ReclamationParent_Nomenclature_EtatReclamation",
                        column: x => x.CodeEtatRecl,
                        principalTable: "Nomenclature_EtatReclamation",
                        principalColumn: "CodeEtatRecl");
                    table.ForeignKey(
                        name: "FK_Reclamation_ReclamationParent_Nomenclature_Priorite",
                        column: x => x.CodePrio,
                        principalTable: "Nomenclature_Priorite",
                        principalColumn: "CodePrio");
                    table.ForeignKey(
                        name: "FK_Reclamation_ReclamationParent_SECURITE_UTILISATEUR",
                        column: x => x.CODEUTIL,
                        principalTable: "SECURITE_UTILISATEUR",
                        principalColumn: "CODEUTIL");
                });

            migrationBuilder.CreateTable(
                name: "Securite_Etablissement",
                columns: table => new
                {
                    CODEUTIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Code commerciale (Login)"),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Securite_Etablissement", x => new { x.CODEUTIL, x.CodeEtab });
                    table.ForeignKey(
                        name: "FK_Securite_Etablissement_Nomenclature_Etablissement",
                        column: x => x.CodeEtab,
                        principalTable: "Nomenclature_Etablissement",
                        principalColumn: "CodeEtab",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Securite_Etablissement_SECURITE_UTILISATEUR",
                        column: x => x.CODEUTIL,
                        principalTable: "SECURITE_UTILISATEUR",
                        principalColumn: "CODEUTIL");
                });

            migrationBuilder.CreateTable(
                name: "Personnel_FormationContinue",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    IdenUniq = table.Column<int>(type: "int", nullable: false, comment: "Identifiant du personnel"),
                    NumeLign = table.Column<int>(type: "int", nullable: false, comment: "Nume sequentielle"),
                    CodeTypeForm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Type formation"),
                    DateForm = table.Column<DateTime>(type: "datetime", nullable: true, comment: "Date formation"),
                    LieuForm = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, comment: "Lieu  formation"),
                    Orga = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, comment: "Organisme"),
                    PeriForm = table.Column<double>(type: "float", nullable: true),
                    SujetForm = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnel_FormationContinue", x => new { x.CodeEtab, x.AnneScol, x.IdenUniq, x.NumeLign });
                    table.ForeignKey(
                        name: "FK_Personnel_FormationContinue_Nomenclature_TypeFormation",
                        column: x => x.CodeTypeForm,
                        principalTable: "Nomenclature_TypeFormation",
                        principalColumn: "CodeTypeForm");
                    table.ForeignKey(
                        name: "FK_Personnel_FormationContinue_Personnel_Personnel",
                        columns: x => new { x.CodeEtab, x.AnneScol, x.IdenUniq },
                        principalTable: "Personnel_Personnel",
                        principalColumns: new[] { "CodeEtab", "AnneScol", "IdenUniq" });
                });

            migrationBuilder.CreateTable(
                name: "Eleve_EleveHandicap",
                columns: table => new
                {
                    NumeElev = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    NomPren = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CodeGenr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code genre"),
                    DateNais = table.Column<DateTime>(type: "date", nullable: true),
                    CodeTypeHand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodeDegrHand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodeInteHand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SuiviCentSpec = table.Column<bool>(type: "bit", nullable: true),
                    AnneNais = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_EleveHandicap", x => new { x.NumeElev, x.CodeEtab, x.AnneScol });
                    table.ForeignKey(
                        name: "FK_Eleve_EleveHandicap_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_EleveHandicap_Nomenclature_DedreHandicap",
                        column: x => x.CodeDegrHand,
                        principalTable: "Nomenclature_DedreHandicap",
                        principalColumn: "CodeDegrHand");
                    table.ForeignKey(
                        name: "FK_Eleve_EleveHandicap_Nomenclature_Genre",
                        column: x => x.CodeGenr,
                        principalTable: "Nomenclature_Genre",
                        principalColumn: "CodeGenr");
                    table.ForeignKey(
                        name: "FK_Eleve_EleveHandicap_Nomenclature_IntergrationHandicap",
                        column: x => x.CodeInteHand,
                        principalTable: "Nomenclature_IntergrationHandicap",
                        principalColumn: "CodeInteHand");
                    table.ForeignKey(
                        name: "FK_Eleve_EleveHandicap_Nomenclature_TypeHandicap",
                        column: x => x.CodeTypeHand,
                        principalTable: "Nomenclature_TypeHandicap",
                        principalColumn: "CodeTypeHand");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionEtatParents",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeEtatPare = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionEtatParents", x => new { x.CodeEtab, x.AnneScol, x.CodeEtatPare });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionEtatParents_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionEtatParents_Nomenclature_EtatParent",
                        column: x => x.CodeEtatPare,
                        principalTable: "Nomenclature_EtatParent",
                        principalColumn: "CodeEtatPare");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionEtatPsycologique",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeEtatPsyc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionEtatPsycologique", x => new { x.CodeEtab, x.AnneScol, x.CodeEtatPsyc });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionEtatPsycologique_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionEtatPsycologique_Nomenclature_EtatPsycologique",
                        column: x => x.CodeEtatPsyc,
                        principalTable: "Nomenclature_EtatPsycologique",
                        principalColumn: "CodeEtatPsyc");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionEtatSante",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeEtatSant = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionEtatSante", x => new { x.CodeEtab, x.AnneScol, x.CodeEtatSant });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionEtatSante_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionEtatSante_Nomenclature_EtatSante",
                        column: x => x.CodeEtatSant,
                        principalTable: "Nomenclature_EtatSante",
                        principalColumn: "CodeEtatSant");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionGroupeTrancheAge",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeTranAge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombGrou = table.Column<int>(type: "int", nullable: true),
                    NombPersPourGrou = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionGroupeTrancheAge", x => new { x.CodeEtab, x.AnneScol, x.CodeTranAge });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionGroupeTrancheAge_Etablissement_FicheEtablissement1",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionGroupeTrancheAge_Nomenclature_TrancheAge1",
                        column: x => x.CodeTranAge,
                        principalTable: "Nomenclature_TrancheAge",
                        principalColumn: "CodeTranAge");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionLangueMaternelle",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeLangMate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionLangueMaternelle", x => new { x.CodeEtab, x.AnneScol, x.CodeLangMate });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionLangueMaternelle_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionLangueMaternelle_Nomenclature_LangueMaternelle",
                        column: x => x.CodeLangMate,
                        principalTable: "Nomenclature_LangueMaternelle",
                        principalColumn: "CodeLangMate");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionNationalite",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeNati = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionNationalite", x => new { x.CodeEtab, x.AnneScol, x.CodeNati });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionNationalite_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionNationalite_Nomenclature_Nationalite",
                        column: x => x.CodeNati,
                        principalTable: "Nomenclature_Nationalite",
                        principalColumn: "CodeNati");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionNiveauEtudeMere",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeNiveEtud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionNiveauEtudeMere", x => new { x.CodeEtab, x.AnneScol, x.CodeNiveEtud });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionNiveauEtudeMere_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionNiveauEtudeMere_Nomenclature_NiveauEtude",
                        column: x => x.CodeNiveEtud,
                        principalTable: "Nomenclature_NiveauEtude",
                        principalColumn: "CodeNiveEtud");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionNiveauEtudePere",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeNiveEtud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionNiveauEtudePere", x => new { x.CodeEtab, x.AnneScol, x.CodeNiveEtud });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionNiveauEtudePere_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionNiveauEtudePere_Nomenclature_NiveauEtude",
                        column: x => x.CodeNiveEtud,
                        principalTable: "Nomenclature_NiveauEtude",
                        principalColumn: "CodeNiveEtud");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionNiveauSalaire",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeNiveSala = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionNiveauSalaire", x => new { x.CodeEtab, x.AnneScol, x.CodeNiveSala });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionNiveauSalaire_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionNiveauSalaire_Nomenclature_NiveauSalaire",
                        column: x => x.CodeNiveSala,
                        principalTable: "Nomenclature_NiveauSalaire",
                        principalColumn: "CodeNiveSala");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionProfessionMere",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeProf = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionProfessionMere", x => new { x.CodeEtab, x.AnneScol, x.CodeProf });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionProfessionMere_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionProfessionMere_Nomenclature_Profession",
                        column: x => x.CodeProf,
                        principalTable: "Nomenclature_Profession",
                        principalColumn: "CodeProf");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionProfessionPere",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeProf = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionProfessionPere", x => new { x.CodeEtab, x.AnneScol, x.CodeProf });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionProfessionPere_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionProfessionPere_Nomenclature_Profession",
                        column: x => x.CodeProf,
                        principalTable: "Nomenclature_Profession",
                        principalColumn: "CodeProf");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionTrancheAgeArretEtude",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeTranAge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionTrancheAgeArretEtude", x => new { x.CodeEtab, x.AnneScol, x.CodeTranAge });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionTrancheAgeArretEtude_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionTrancheAgeArretEtude_Nomenclature_TrancheAge",
                        column: x => x.CodeTranAge,
                        principalTable: "Nomenclature_TrancheAge",
                        principalColumn: "CodeTranAge");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionTrancheAgeBeneficaire",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeTranAge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionTrancheAgeBeneficaire", x => new { x.CodeEtab, x.AnneScol, x.CodeTranAge });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionTrancheAgeBeneficaire_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionTrancheAgeBeneficaire_Nomenclature_TrancheAge",
                        column: x => x.CodeTranAge,
                        principalTable: "Nomenclature_TrancheAge",
                        principalColumn: "CodeTranAge");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionTrancheAgeTypePriseEnCharge",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeTranAge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodeTypePrisChar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionTrancheAgeTypePriseEnCharge", x => new { x.CodeEtab, x.AnneScol, x.CodeTranAge, x.CodeTypePrisChar });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionTrancheAgeNomenclature_TrancheAge",
                        column: x => x.CodeTranAge,
                        principalTable: "Nomenclature_TrancheAge",
                        principalColumn: "CodeTranAge");
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionTrancheAgeTypePriseEnCharge_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionTrancheAgeTypePriseEnCharge_Nomenclature_TypePriseEnCharge",
                        column: x => x.CodeTypePrisChar,
                        principalTable: "Nomenclature_TypePriseEnCharge",
                        principalColumn: "CodeTypePrisChar");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionTypeInscription",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeTypeInsc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionTypeInscription", x => new { x.CodeEtab, x.AnneScol, x.CodeTypeInsc });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionTypeInscription_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionTypeInscription_Nomenclature_TypeInscription",
                        column: x => x.CodeTypeInsc,
                        principalTable: "Nomenclature_TypeInscription",
                        principalColumn: "CodeTypeInsc");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionTypePriseEnCharge",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeTypePrisChar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code Niveau d'Etude"),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionTypePriseEnCharge", x => new { x.CodeEtab, x.AnneScol, x.CodeTypePrisChar });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionTypePriseEnCharge_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionTypePriseEnCharge_Nomenclature_TypePriseEnCharge",
                        column: x => x.CodeTypePrisChar,
                        principalTable: "Nomenclature_TypePriseEnCharge",
                        principalColumn: "CodeTypePrisChar");
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_Anomalie",
                columns: table => new
                {
                    Nume = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    DateVisi = table.Column<DateTime>(type: "datetime", nullable: true),
                    DurePrisEnCharg = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Obse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODEUTIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Code commerciale (Login)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_Anomalie", x => new { x.Nume, x.CodeEtab, x.AnneScol });
                    table.ForeignKey(
                        name: "FK_Etablissement_Anomalie_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" });
                    table.ForeignKey(
                        name: "FK_Etablissement_Anomalie_SECURITE_UTILISATEUR",
                        column: x => x.CODEUTIL,
                        principalTable: "SECURITE_UTILISATEUR",
                        principalColumn: "CODEUTIL");
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_Equipement",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeEqui = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nomb = table.Column<int>(type: "int", nullable: true),
                    ConfCara = table.Column<bool>(type: "bit", nullable: true),
                    Disp = table.Column<bool>(type: "bit", nullable: true),
                    Obse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfCaraType = table.Column<bool>(type: "bit", nullable: false),
                    DispType = table.Column<bool>(type: "bit", nullable: false),
                    ObseType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_Equipement", x => new { x.CodeEtab, x.AnneScol, x.CodeEqui });
                    table.ForeignKey(
                        name: "FK_Etablissement_Equipement_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etablissement_Equipement_Nomenclature_Equipement",
                        column: x => x.CodeEqui,
                        principalTable: "Nomenclature_Equipement",
                        principalColumn: "CodeEqui",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_Espace",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    NumeEspa = table.Column<int>(type: "int", nullable: false),
                    CodeTypeEspa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code Type Equipement"),
                    Surf = table.Column<double>(type: "float", nullable: true),
                    Haut = table.Column<double>(type: "float", nullable: true),
                    Obse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_Espace_1", x => new { x.CodeEtab, x.AnneScol, x.NumeEspa });
                    table.ForeignKey(
                        name: "FK_Etablissement_Espace_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etablissement_Espace_Nomenclature_TypeEspace",
                        column: x => x.CodeTypeEspa,
                        principalTable: "Nomenclature_TypeEspace",
                        principalColumn: "CodeTypeEspa");
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_Infrastructure",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeEmplSieg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "مقرّ المؤسسة"),
                    AutrEmplSieg = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "غير ذلك حدده"),
                    CodeTypeProp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "نوع العقار"),
                    CodeRegiProp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "ملكية العقار"),
                    SurfTota = table.Column<double>(type: "float", nullable: true, comment: "المساحةالجملية"),
                    SurfBati = table.Column<double>(type: "float", nullable: true, comment: "المساحة المغطاة"),
                    SurfEspaExte = table.Column<double>(type: "float", nullable: true, comment: "مساحة الفضاء الخارجي"),
                    Clot = table.Column<bool>(type: "bit", nullable: true, comment: "المؤسسة محاطة بسياج"),
                    CodeTypeClot = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "نوع السياج"),
                    HautClot = table.Column<double>(type: "float", nullable: true, comment: "ارتفاع السياج"),
                    PassSpecPersBesoSpec = table.Column<bool>(type: "bit", nullable: true, comment: "يوجد ممر خاص بذوي الاحتياجات الخصوصية"),
                    TeleFixe = table.Column<bool>(type: "bit", nullable: true, comment: "هاتف قار"),
                    ConnInte = table.Column<bool>(type: "bit", nullable: true, comment: "المؤسسة مرتبطة بشبكة الأنترنات"),
                    existTerrain = table.Column<bool>(type: "bit", nullable: true),
                    SurfaceTerrain = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodeTypeTerrain = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_Infrastructure", x => new { x.CodeEtab, x.AnneScol });
                    table.ForeignKey(
                        name: "FK_Etablissement_Infrastructure_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etablissement_Infrastructure_Nomenclature_EmplacementSiege",
                        column: x => x.CodeEmplSieg,
                        principalTable: "Nomenclature_EmplacementSiege",
                        principalColumn: "CodeEmplSieg");
                    table.ForeignKey(
                        name: "FK_Etablissement_Infrastructure_Nomenclature_RegimePropriete",
                        column: x => x.CodeRegiProp,
                        principalTable: "Nomenclature_RegimePropriete",
                        principalColumn: "CodeRegiProp");
                    table.ForeignKey(
                        name: "FK_Etablissement_Infrastructure_Nomenclature_TypeCloture",
                        column: x => x.CodeTypeClot,
                        principalTable: "Nomenclature_TypeCloture",
                        principalColumn: "CodeTypeClot");
                    table.ForeignKey(
                        name: "FK_Etablissement_Infrastructure_Nomenclature_TypePropriete",
                        column: x => x.CodeTypeProp,
                        principalTable: "Nomenclature_TypePropriete",
                        principalColumn: "CodeTypeProp");
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_Infrastructure_Autre",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodetypeInfra = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    @checked = table.Column<bool>(name: "checked", type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_Infrastructure_Autre", x => new { x.CodeEtab, x.AnneScol, x.CodetypeInfra });
                    table.ForeignKey(
                        name: "FK_[Etablissement_Infrastructure_Autre_Nomenclature_Infrastrcture",
                        column: x => x.CodetypeInfra,
                        principalTable: "Nomenclature_Infrastrcture",
                        principalColumn: "CodeInfrastrcture");
                    table.ForeignKey(
                        name: "FK_Infrastructure_Autre_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_Intervention",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    CodeInterv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    @checked = table.Column<bool>(name: "checked", type: "bit", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_Intervention", x => new { x.CodeEtab, x.AnneScol, x.CodeInterv });
                    table.ForeignKey(
                        name: "FK_Etablissement_Intervention_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etablissement_Intervention_Nomenclature_Infrastrcture",
                        column: x => x.CodeInterv,
                        principalTable: "Nomenclature_Interventionnecessaire",
                        principalColumn: "CodeInterv");
                });

            migrationBuilder.CreateTable(
                name: "Reclamation_Reclamation",
                columns: table => new
                {
                    NumeRecl = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AnneScol = table.Column<int>(type: "int", nullable: false),
                    NomPrenPersRecl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DateRecl = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sujet = table.Column<string>(type: "text", nullable: true, collation: "Arabic_CI_AS"),
                    Affe = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Rapp = table.Column<string>(type: "text", nullable: true, collation: "Arabic_CI_AS"),
                    ObseDeci = table.Column<string>(type: "text", nullable: true),
                    CodeEtatRecl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CodePrio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reclamation_Reclamation", x => new { x.NumeRecl, x.CodeEtab, x.AnneScol });
                    table.ForeignKey(
                        name: "FK_Reclamation_Reclamation_Etablissement_FicheEtablissement",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_FicheEtablissement",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reclamation_Reclamation_Nomenclature_EtatReclamation",
                        column: x => x.CodeEtatRecl,
                        principalTable: "Nomenclature_EtatReclamation",
                        principalColumn: "CodeEtatRecl");
                    table.ForeignKey(
                        name: "FK_Reclamation_Reclamation_Nomenclature_Priorite",
                        column: x => x.CodePrio,
                        principalTable: "Nomenclature_Priorite",
                        principalColumn: "CodePrio");
                });

            migrationBuilder.CreateTable(
                name: "Eleve_RepartitionTrancheAge",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeTranAge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumeGrou = table.Column<int>(type: "int", nullable: false),
                    NombFemi = table.Column<int>(type: "int", nullable: true),
                    NombMasc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleve_RepartitionTrancheAge", x => new { x.CodeEtab, x.AnneScol, x.CodeTranAge, x.NumeGrou });
                    table.ForeignKey(
                        name: "FK_Eleve_RepartitionTrancheAge_Eleve_RepartitionGroupeTrancheAge",
                        columns: x => new { x.CodeEtab, x.AnneScol, x.CodeTranAge },
                        principalTable: "Eleve_RepartitionGroupeTrancheAge",
                        principalColumns: new[] { "CodeEtab", "AnneScol", "CodeTranAge" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_AnomalieEtablissement",
                columns: table => new
                {
                    Nume = table.Column<int>(type: "int", nullable: false),
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeAnom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Commune")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_AnomalieEtablissement", x => new { x.Nume, x.CodeEtab, x.AnneScol, x.CodeAnom });
                    table.ForeignKey(
                        name: "FK_Etablissement_AnomalieEtablissement_Etablissement_Anomalie",
                        columns: x => new { x.Nume, x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_Anomalie",
                        principalColumns: new[] { "Nume", "CodeEtab", "AnneScol" });
                    table.ForeignKey(
                        name: "FK_Etablissement_AnomalieEtablissement_Nomenclature_Anomalie",
                        column: x => x.CodeAnom,
                        principalTable: "Nomenclature_Anomalie",
                        principalColumn: "CodeAnom");
                });

            migrationBuilder.CreateTable(
                name: "Etablissement_EspaceCaracteristiqueEspace",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    NumeEspa = table.Column<int>(type: "int", nullable: false),
                    CodeCaraEspa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ConfCara = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissement_EspaceCaracteristiqueEspace", x => new { x.CodeEtab, x.AnneScol, x.NumeEspa, x.CodeCaraEspa });
                    table.ForeignKey(
                        name: "FK_Etablissement_EspaceCaracteristiqueEspace_Etablissement_Espace",
                        columns: x => new { x.CodeEtab, x.AnneScol, x.NumeEspa },
                        principalTable: "Etablissement_Espace",
                        principalColumns: new[] { "CodeEtab", "AnneScol", "NumeEspa" });
                    table.ForeignKey(
                        name: "FK_Etablissement_EspaceCaracteristiqueEspace_Nomenclature_CaracteristiqueEspace",
                        column: x => x.CodeCaraEspa,
                        principalTable: "Nomenclature_CaracteristiqueEspace",
                        principalColumn: "CodeCaraEspa");
                });

            migrationBuilder.CreateTable(
                name: "Infrastructure_CaracteristiqueEspaceExterieur",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeCaraEspaExte = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "خصائص الفضاء الخارجي")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Infrastructure_CaracteristiqueEspaceExterieur_Etablissement_Infrastructure",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_Infrastructure",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Infrastructure_CaracteristiqueEspaceExterieur_Nomenclature_CaracteristiqueEspaceExterieur",
                        column: x => x.CodeCaraEspaExte,
                        principalTable: "Nomenclature_CaracteristiqueEspaceExterieur",
                        principalColumn: "CodeCaraEspaExte");
                });

            migrationBuilder.CreateTable(
                name: "Infrastructure_Emplacement",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeEmpl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "خصائص الفضاء الخارجي")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Infrastructure_Emplacement_Etablissement_Infrastructure",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_Infrastructure",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Infrastructure_Emplacement_Nomenclature_Emplacement",
                        column: x => x.CodeEmpl,
                        principalTable: "Nomenclature_EmplacementEtablissement",
                        principalColumn: "CodeEmpl");
                });

            migrationBuilder.CreateTable(
                name: "Infrastructure_TypeConnexionInternet",
                columns: table => new
                {
                    CodeEtab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Code établissement"),
                    AnneScol = table.Column<int>(type: "int", nullable: false, comment: "Année scolaire"),
                    CodeTypeConnInte = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "خصائص الفضاء الخارجي")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Infrastructure_TypeConnexionInternet_Etablissement_Infrastructure",
                        columns: x => new { x.CodeEtab, x.AnneScol },
                        principalTable: "Etablissement_Infrastructure",
                        principalColumns: new[] { "CodeEtab", "AnneScol" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Infrastructure_TypeConnexionInternet_Nomenclature_TypeConnexionInternet",
                        column: x => x.CodeTypeConnInte,
                        principalTable: "Nomenclature_TypeConnexionInternet",
                        principalColumn: "CodeTypeConnInte");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_EleveHandicap_CodeDegrHand",
                table: "Eleve_EleveHandicap",
                column: "CodeDegrHand");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_EleveHandicap_CodeEtab_AnneScol",
                table: "Eleve_EleveHandicap",
                columns: new[] { "CodeEtab", "AnneScol" });

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_EleveHandicap_CodeGenr",
                table: "Eleve_EleveHandicap",
                column: "CodeGenr");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_EleveHandicap_CodeInteHand",
                table: "Eleve_EleveHandicap",
                column: "CodeInteHand");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_EleveHandicap_CodeTypeHand",
                table: "Eleve_EleveHandicap",
                column: "CodeTypeHand");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionEtatParents_CodeEtatPare",
                table: "Eleve_RepartitionEtatParents",
                column: "CodeEtatPare");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionEtatPsycologique_CodeEtatPsyc",
                table: "Eleve_RepartitionEtatPsycologique",
                column: "CodeEtatPsyc");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionEtatSante_CodeEtatSant",
                table: "Eleve_RepartitionEtatSante",
                column: "CodeEtatSant");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionGroupeTrancheAge_CodeTranAge",
                table: "Eleve_RepartitionGroupeTrancheAge",
                column: "CodeTranAge");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionLangueMaternelle_CodeLangMate",
                table: "Eleve_RepartitionLangueMaternelle",
                column: "CodeLangMate");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionNationalite_CodeNati",
                table: "Eleve_RepartitionNationalite",
                column: "CodeNati");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionNiveauEtudeMere_CodeNiveEtud",
                table: "Eleve_RepartitionNiveauEtudeMere",
                column: "CodeNiveEtud");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionNiveauEtudePere_CodeNiveEtud",
                table: "Eleve_RepartitionNiveauEtudePere",
                column: "CodeNiveEtud");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionNiveauSalaire_CodeNiveSala",
                table: "Eleve_RepartitionNiveauSalaire",
                column: "CodeNiveSala");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionProfessionMere_CodeProf",
                table: "Eleve_RepartitionProfessionMere",
                column: "CodeProf");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionProfessionPere_CodeProf",
                table: "Eleve_RepartitionProfessionPere",
                column: "CodeProf");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionTrancheAgeArretEtude_CodeTranAge",
                table: "Eleve_RepartitionTrancheAgeArretEtude",
                column: "CodeTranAge");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionTrancheAgeBeneficaire_CodeTranAge",
                table: "Eleve_RepartitionTrancheAgeBeneficaire",
                column: "CodeTranAge");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionTrancheAgeTypePriseEnCharge_CodeTranAge",
                table: "Eleve_RepartitionTrancheAgeTypePriseEnCharge",
                column: "CodeTranAge");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionTrancheAgeTypePriseEnCharge_CodeTypePrisChar",
                table: "Eleve_RepartitionTrancheAgeTypePriseEnCharge",
                column: "CodeTypePrisChar");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionTypeInscription_CodeTypeInsc",
                table: "Eleve_RepartitionTypeInscription",
                column: "CodeTypeInsc");

            migrationBuilder.CreateIndex(
                name: "IX_Eleve_RepartitionTypePriseEnCharge_CodeTypePrisChar",
                table: "Eleve_RepartitionTypePriseEnCharge",
                column: "CodeTypePrisChar");

            migrationBuilder.CreateIndex(
                name: "IX_ENFANT_necessite_CodeComm",
                table: "ENFANT_necessite",
                column: "CodeComm");

            migrationBuilder.CreateIndex(
                name: "IX_ENFANT_necessite_CodeDele",
                table: "ENFANT_necessite",
                column: "CodeDele");

            migrationBuilder.CreateIndex(
                name: "IX_ENFANT_necessite_CodeTypeEtab",
                table: "ENFANT_necessite",
                column: "CodeTypeEtab");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_Anomalie_CodeEtab_AnneScol",
                table: "Etablissement_Anomalie",
                columns: new[] { "CodeEtab", "AnneScol" });

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_Anomalie_CODEUTIL",
                table: "Etablissement_Anomalie",
                column: "CODEUTIL");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_AnomalieEtablissement_CodeAnom",
                table: "Etablissement_AnomalieEtablissement",
                column: "CodeAnom");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_Equipement_CodeEqui",
                table: "Etablissement_Equipement",
                column: "CodeEqui");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_Espace_CodeTypeEspa",
                table: "Etablissement_Espace",
                column: "CodeTypeEspa");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_EspaceCaracteristiqueEspace_CodeCaraEspa",
                table: "Etablissement_EspaceCaracteristiqueEspace",
                column: "CodeCaraEspa");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_FicheEtablissement_CodeDele",
                table: "Etablissement_FicheEtablissement",
                column: "CodeDele");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_FicheEtablissement_CodeOuveEtab",
                table: "Etablissement_FicheEtablissement",
                column: "CodeOuveEtab");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_Infrastructure_CodeEmplSieg",
                table: "Etablissement_Infrastructure",
                column: "CodeEmplSieg");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_Infrastructure_CodeRegiProp",
                table: "Etablissement_Infrastructure",
                column: "CodeRegiProp");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_Infrastructure_CodeTypeClot",
                table: "Etablissement_Infrastructure",
                column: "CodeTypeClot");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_Infrastructure_CodeTypeProp",
                table: "Etablissement_Infrastructure",
                column: "CodeTypeProp");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_Infrastructure_Autre_CodetypeInfra",
                table: "Etablissement_Infrastructure_Autre",
                column: "CodetypeInfra");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_Intervention_CodeInterv",
                table: "Etablissement_Intervention",
                column: "CodeInterv");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_OrganisationAdministrative_CodeOrgaAdmi",
                table: "Etablissement_OrganisationAdministrative",
                column: "CodeOrgaAdmi");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissement_OrganisationPedagogique_CodeOrgaPeda",
                table: "Etablissement_OrganisationPedagogique",
                column: "CodeOrgaPeda");

            migrationBuilder.CreateIndex(
                name: "IX_Infrastructure_CaracteristiqueEspaceExterieur_CodeCaraEspaExte",
                table: "Infrastructure_CaracteristiqueEspaceExterieur",
                column: "CodeCaraEspaExte");

            migrationBuilder.CreateIndex(
                name: "IX_Infrastructure_CaracteristiqueEspaceExterieur_CodeEtab_AnneScol",
                table: "Infrastructure_CaracteristiqueEspaceExterieur",
                columns: new[] { "CodeEtab", "AnneScol" });

            migrationBuilder.CreateIndex(
                name: "IX_Infrastructure_Emplacement_CodeEmpl",
                table: "Infrastructure_Emplacement",
                column: "CodeEmpl");

            migrationBuilder.CreateIndex(
                name: "IX_Infrastructure_Emplacement_CodeEtab_AnneScol",
                table: "Infrastructure_Emplacement",
                columns: new[] { "CodeEtab", "AnneScol" });

            migrationBuilder.CreateIndex(
                name: "IX_Infrastructure_TypeConnexionInternet_CodeEtab_AnneScol",
                table: "Infrastructure_TypeConnexionInternet",
                columns: new[] { "CodeEtab", "AnneScol" });

            migrationBuilder.CreateIndex(
                name: "IX_Infrastructure_TypeConnexionInternet_CodeTypeConnInte",
                table: "Infrastructure_TypeConnexionInternet",
                column: "CodeTypeConnInte");

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_Anomalie_CodeAnom",
                table: "Inspection_Anomalie",
                column: "CodeAnom");

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_Constatation_CodeRubrInsp",
                table: "Inspection_Constatation",
                column: "CodeRubrInsp");

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_DeductionCategorieRubriqueInspection_CodeCateRubrInsp",
                table: "Inspection_DeductionCategorieRubriqueInspection",
                column: "CodeCateRubrInsp");

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_Infrastructure_NumeVisiInsp_CodeEtab_AnneScol",
                table: "Inspection_Infrastructure",
                columns: new[] { "NumeVisiInsp", "CodeEtab", "AnneScol" });

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_NombreEnfantTrancheAge_CodeTranAge",
                table: "Inspection_NombreEnfantTrancheAge",
                column: "CodeTranAge");

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_Recifications_CodeRect",
                table: "Inspection_Recifications",
                column: "CodeRect");

            migrationBuilder.CreateIndex(
                name: "index_Etab_anne",
                table: "Inspection_VisiteInspection",
                columns: new[] { "CodeEtab", "AnneScol" });

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_VisiteInspection_CodeTypeInsp",
                table: "Inspection_VisiteInspection",
                column: "CodeTypeInsp");

            migrationBuilder.CreateIndex(
                name: "IX_Message_Fichier_idMessage",
                table: "Message_Fichier",
                column: "idMessage");

            migrationBuilder.CreateIndex(
                name: "IX_Message_Groupe_idMessage",
                table: "Message_Groupe",
                column: "idMessage");

            migrationBuilder.CreateIndex(
                name: "IX_Message_Message_CodeTypeM",
                table: "Message_Message",
                column: "CodeTypeM");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_CaracteristiqueEspace_CodeTypeEspa",
                table: "Nomenclature_CaracteristiqueEspace",
                column: "CodeTypeEspa");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_CategorieRubriqueInspection_CodeTypeEtab",
                table: "Nomenclature_CategorieRubriqueInspection",
                column: "CodeTypeEtab");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_CategorieRubriqueTypeInspection_CodeCateRubrInsp",
                table: "Nomenclature_CategorieRubriqueTypeInspection",
                column: "CodeCateRubrInsp");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_ConstatationRubriqueInspection_CodeCons",
                table: "Nomenclature_ConstatationRubriqueInspection",
                column: "CodeCons");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Delegation_CodeGouv",
                table: "Nomenclature_Delegation",
                column: "CodeGouv");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Equipement_CodeTypeEqui",
                table: "Nomenclature_Equipement",
                column: "CodeTypeEqui");

            migrationBuilder.CreateIndex(
                name: "index_Etab_2",
                table: "Nomenclature_Etablissement",
                column: "CodeEtab");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Etablissement_CodeComm",
                table: "Nomenclature_Etablissement",
                column: "CodeComm");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Etablissement_CodeDele",
                table: "Nomenclature_Etablissement",
                column: "CodeDele");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Etablissement_CodeDeleFond",
                table: "Nomenclature_Etablissement",
                column: "CodeDeleFond");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Etablissement_CodeDipl",
                table: "Nomenclature_Etablissement",
                column: "CodeDipl");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Etablissement_CodeNiveEtud",
                table: "Nomenclature_Etablissement",
                column: "CodeNiveEtud");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Etablissement_CodeSect",
                table: "Nomenclature_Etablissement",
                column: "CodeSect");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Etablissement_CodeSituFami",
                table: "Nomenclature_Etablissement",
                column: "CodeSituFami");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Etablissement_CodeZoneHabi",
                table: "Nomenclature_Etablissement",
                column: "CodeZoneHabi");

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20201201-132620",
                table: "Nomenclature_Etablissement",
                column: "CodeTypeEtab");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_EtatEtablissement_CodeTypeEtatEtab",
                table: "Nomenclature_EtatEtablissement",
                column: "CodeTypeEtatEtab");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Gouvernorat_CodeDist",
                table: "Nomenclature_Gouvernorat",
                column: "CodeDist");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_OrganisationAdministrative_CodeTypeEtab",
                table: "Nomenclature_OrganisationAdministrative",
                column: "CodeTypeEtab");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_OrganisationPedagogique_CodeTypeEtab",
                table: "Nomenclature_OrganisationPedagogique",
                column: "CodeTypeEtab");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_RubriqueInspection_CodeCateRubrInsp",
                table: "Nomenclature_RubriqueInspection",
                column: "CodeCateRubrInsp");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Signalisation_CodeConcerne",
                table: "Nomenclature_Signalisation",
                column: "CodeConcerne");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Signalisation_CodeDele",
                table: "Nomenclature_Signalisation",
                column: "CodeDele");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Signalisation_CodeGouv",
                table: "Nomenclature_Signalisation",
                column: "CodeGouv");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Signalisation_CodeInformateur",
                table: "Nomenclature_Signalisation",
                column: "CodeInformateur");

            migrationBuilder.CreateIndex(
                name: "IX_Nomenclature_Signalisation_CodeTypeSignalisation",
                table: "Nomenclature_Signalisation",
                column: "CodeTypeSignalisation");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_FormationContinue_CodeTypeForm",
                table: "Personnel_FormationContinue",
                column: "CodeTypeForm");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_Personnel_CodeCorp",
                table: "Personnel_Personnel",
                column: "CodeCorp");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_Personnel_CodeDele",
                table: "Personnel_Personnel",
                column: "CodeDele");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_Personnel_CodeDipl",
                table: "Personnel_Personnel",
                column: "CodeDipl");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_Personnel_CodeFonc",
                table: "Personnel_Personnel",
                column: "CodeFonc");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_Personnel_CodeGenr",
                table: "Personnel_Personnel",
                column: "CodeGenr");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_Personnel_CodeGrad",
                table: "Personnel_Personnel",
                column: "CodeGrad");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_Personnel_CodeNiveEtud",
                table: "Personnel_Personnel",
                column: "CodeNiveEtud");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_Personnel_CodeQual",
                table: "Personnel_Personnel",
                column: "CodeQual");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_Personnel_CodeReveMens",
                table: "Personnel_Personnel",
                column: "CodeReveMens");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_Personnel_CodeSituProf",
                table: "Personnel_Personnel",
                column: "CodeSituProf");

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20201231-175555",
                table: "Personnel_Personnel",
                column: "NumeCIN");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamation_Reclamation_CodeEtab_AnneScol",
                table: "Reclamation_Reclamation",
                columns: new[] { "CodeEtab", "AnneScol" });

            migrationBuilder.CreateIndex(
                name: "IX_Reclamation_Reclamation_CodeEtatRecl",
                table: "Reclamation_Reclamation",
                column: "CodeEtatRecl");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamation_Reclamation_CodePrio",
                table: "Reclamation_Reclamation",
                column: "CodePrio");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamation_ReclamationParent_CodeEtab",
                table: "Reclamation_ReclamationParent",
                column: "CodeEtab");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamation_ReclamationParent_CodeEtatRecl",
                table: "Reclamation_ReclamationParent",
                column: "CodeEtatRecl");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamation_ReclamationParent_CodePrio",
                table: "Reclamation_ReclamationParent",
                column: "CodePrio");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamation_ReclamationParent_CODEUTIL",
                table: "Reclamation_ReclamationParent",
                column: "CODEUTIL");

            migrationBuilder.CreateIndex(
                name: "IX_SECURITE_DROITACCESGROUPE_CODEENTI",
                table: "SECURITE_DROITACCESGROUPE",
                column: "CODEENTI");

            migrationBuilder.CreateIndex(
                name: "IX_SECURITE_DROITACCESUTILISATEUR_CODEUTIL",
                table: "SECURITE_DROITACCESUTILISATEUR",
                column: "CODEUTIL");

            migrationBuilder.CreateIndex(
                name: "IX_SECURITE_ENTITE_CODEPACK",
                table: "SECURITE_ENTITE",
                column: "CODEPACK");

            migrationBuilder.CreateIndex(
                name: "IX_Securite_Etablissement_CodeEtab",
                table: "Securite_Etablissement",
                column: "CodeEtab");

            migrationBuilder.CreateIndex(
                name: "IX_SECURITE_TRACEUTILISATEUR_CODETYPEOPER",
                table: "SECURITE_TRACEUTILISATEUR",
                column: "CODETYPEOPER");

            migrationBuilder.CreateIndex(
                name: "IX_SECURITE_TRACEUTILISATEUR_CODEUTIL",
                table: "SECURITE_TRACEUTILISATEUR",
                column: "CODEUTIL");

            migrationBuilder.CreateIndex(
                name: "IX_SECURITE_UTILISATEUR_CODEGROUUTIL",
                table: "SECURITE_UTILISATEUR",
                column: "CODEGROUUTIL");

            migrationBuilder.CreateIndex(
                name: "IX_SECURITE_UTILISATEUR_CODENIVEHIER",
                table: "SECURITE_UTILISATEUR",
                column: "CODENIVEHIER");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activite_fiche");

            migrationBuilder.DropTable(
                name: "Activite_paraticipant");

            migrationBuilder.DropTable(
                name: "Eleve_EleveHandicap");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionEtatParents");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionEtatPsycologique");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionEtatSante");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionGroupeTrancheAge_old01122020");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionGroupeTrancheAge_old02122020");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionLangueMaternelle");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionNationalite");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionNiveauEtudeMere");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionNiveauEtudePere");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionNiveauSalaire");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionProfessionMere");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionProfessionPere");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionTrancheAge");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionTrancheAge_old02122020");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionTrancheAgeArretEtude");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionTrancheAgeBeneficaire");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionTrancheAgeTypePriseEnCharge");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionTypeInscription");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionTypePriseEnCharge");

            migrationBuilder.DropTable(
                name: "ENFANT_necessite");

            migrationBuilder.DropTable(
                name: "Etablissement_AnomalieEtablissement");

            migrationBuilder.DropTable(
                name: "Etablissement_Club");

            migrationBuilder.DropTable(
                name: "Etablissement_ClubGeneral");

            migrationBuilder.DropTable(
                name: "Etablissement_ClubGeneral_05012022");

            migrationBuilder.DropTable(
                name: "Etablissement_EnfantNE");

            migrationBuilder.DropTable(
                name: "Etablissement_Equipement");

            migrationBuilder.DropTable(
                name: "Etablissement_EspaceCaracteristiqueEspace");

            migrationBuilder.DropTable(
                name: "Etablissement_HistoriqueEtatEtab");

            migrationBuilder.DropTable(
                name: "Etablissement_Infrastructure_Autre");

            migrationBuilder.DropTable(
                name: "Etablissement_Intervention");

            migrationBuilder.DropTable(
                name: "Etablissement_lienexterne");

            migrationBuilder.DropTable(
                name: "Etablissement_OrganisationAdministrative");

            migrationBuilder.DropTable(
                name: "Etablissement_OrganisationPedagogique");

            migrationBuilder.DropTable(
                name: "Etablissement_Terrain");

            migrationBuilder.DropTable(
                name: "Event_fiche");

            migrationBuilder.DropTable(
                name: "Event_paraticipant");

            migrationBuilder.DropTable(
                name: "Formation_Corps");

            migrationBuilder.DropTable(
                name: "Formation_fiche");

            migrationBuilder.DropTable(
                name: "Formation_Inspecteur");

            migrationBuilder.DropTable(
                name: "Formation_paraticipant");

            migrationBuilder.DropTable(
                name: "Formation_TypeEtablissement");

            migrationBuilder.DropTable(
                name: "Infrastructure_CaracteristiqueEspaceExterieur");

            migrationBuilder.DropTable(
                name: "Infrastructure_Emplacement");

            migrationBuilder.DropTable(
                name: "Infrastructure_TypeConnexionInternet");

            migrationBuilder.DropTable(
                name: "Inspection_Anomalie");

            migrationBuilder.DropTable(
                name: "Inspection_Club");

            migrationBuilder.DropTable(
                name: "Inspection_Constatation");

            migrationBuilder.DropTable(
                name: "Inspection_DeductionCategorieRubriqueInspection");

            migrationBuilder.DropTable(
                name: "Inspection_ElevePresent");

            migrationBuilder.DropTable(
                name: "Inspection_EnfantNE");

            migrationBuilder.DropTable(
                name: "Inspection_Equipement");

            migrationBuilder.DropTable(
                name: "Inspection_espace");

            migrationBuilder.DropTable(
                name: "Inspection_FichierJoint");

            migrationBuilder.DropTable(
                name: "Inspection_InfoGenerale");

            migrationBuilder.DropTable(
                name: "Inspection_Infrastructure");

            migrationBuilder.DropTable(
                name: "Inspection_Infrastructure_Autre");

            migrationBuilder.DropTable(
                name: "Inspection_intervention");

            migrationBuilder.DropTable(
                name: "Inspection_Lienexterne");

            migrationBuilder.DropTable(
                name: "Inspection_NiveauEtude");

            migrationBuilder.DropTable(
                name: "Inspection_NombreEnfantTrancheAge");

            migrationBuilder.DropTable(
                name: "Inspection_Recifications");

            migrationBuilder.DropTable(
                name: "Inspection_RepartitionHandicap");

            migrationBuilder.DropTable(
                name: "Inspection_RepartitionPersonel");

            migrationBuilder.DropTable(
                name: "Inspection_RepartitionPersonelFonction");

            migrationBuilder.DropTable(
                name: "Inspection_RepartitionTrancheAge");

            migrationBuilder.DropTable(
                name: "Inspection_RepartitionTrancheAgeArretEtude");

            migrationBuilder.DropTable(
                name: "Inspection_RepartitionTrancheAgeBeneficaire");

            migrationBuilder.DropTable(
                name: "Inspection_RepartitionTrancheAgeTypePriseEnCharge");

            migrationBuilder.DropTable(
                name: "Inspection_RepartitionTypePriseEnCharge");

            migrationBuilder.DropTable(
                name: "Message_Fichier");

            migrationBuilder.DropTable(
                name: "Message_Groupe");

            migrationBuilder.DropTable(
                name: "message_recuuser");

            migrationBuilder.DropTable(
                name: "Message_User");

            migrationBuilder.DropTable(
                name: "Nome_TypeFichierJoint");

            migrationBuilder.DropTable(
                name: "Nomenclature_activite");

            migrationBuilder.DropTable(
                name: "Nomenclature_CategorieRubriqueActivite");

            migrationBuilder.DropTable(
                name: "Nomenclature_CategorieRubriqueTypeInspection");

            migrationBuilder.DropTable(
                name: "Nomenclature_Cercle");

            migrationBuilder.DropTable(
                name: "Nomenclature_Club");

            migrationBuilder.DropTable(
                name: "Nomenclature_ConstatationRubriqueInspection");

            migrationBuilder.DropTable(
                name: "Nomenclature_Couverture");

            migrationBuilder.DropTable(
                name: "Nomenclature_DecisionReclamation");

            migrationBuilder.DropTable(
                name: "Nomenclature_ElevePresent");

            migrationBuilder.DropTable(
                name: "Nomenclature_EtatEtablissement");

            migrationBuilder.DropTable(
                name: "Nomenclature_EtatFamille");

            migrationBuilder.DropTable(
                name: "Nomenclature_EtatSignalisation");

            migrationBuilder.DropTable(
                name: "Nomenclature_Generale");

            migrationBuilder.DropTable(
                name: "Nomenclature_LienExterne");

            migrationBuilder.DropTable(
                name: "Nomenclature_MethodeSignalisation");

            migrationBuilder.DropTable(
                name: "Nomenclature_MinistereFondatrice");

            migrationBuilder.DropTable(
                name: "Nomenclature_NatureActivite");

            migrationBuilder.DropTable(
                name: "Nomenclature_NatureAnomalie");

            migrationBuilder.DropTable(
                name: "Nomenclature_Natureformateur");

            migrationBuilder.DropTable(
                name: "Nomenclature_Natureformation");

            migrationBuilder.DropTable(
                name: "Nomenclature_NatureInvest");

            migrationBuilder.DropTable(
                name: "Nomenclature_NaturePere");

            migrationBuilder.DropTable(
                name: "Nomenclature_NatureProposition");

            migrationBuilder.DropTable(
                name: "Nomenclature_NatureSignalisation");

            migrationBuilder.DropTable(
                name: "Nomenclature_NiveauEleve");

            migrationBuilder.DropTable(
                name: "Nomenclature_NiveauFormation");

            migrationBuilder.DropTable(
                name: "Nomenclature_SecteurFormation");

            migrationBuilder.DropTable(
                name: "Nomenclature_Signalisation");

            migrationBuilder.DropTable(
                name: "Nomenclature_StatutSignalisation");

            migrationBuilder.DropTable(
                name: "Nomenclature_StructureAttache");

            migrationBuilder.DropTable(
                name: "Nomenclature_Terrain");

            migrationBuilder.DropTable(
                name: "Nomenclature_TrangeAgeCouv");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeAffiche");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeBoolean");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeFormulaire");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeIntervention");

            migrationBuilder.DropTable(
                name: "Nomenclature_Typeproposition");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeRepartition");

            migrationBuilder.DropTable(
                name: "Parametrage_AnneeScolaire");

            migrationBuilder.DropTable(
                name: "Parametrage_ColumnRechercheMultiCritere");

            migrationBuilder.DropTable(
                name: "Parametrage_Columns");

            migrationBuilder.DropTable(
                name: "Parametrage_CubeAnalyse");

            migrationBuilder.DropTable(
                name: "Parametrage_DimensionCube");

            migrationBuilder.DropTable(
                name: "Parametrage_GroupeNomenclature");

            migrationBuilder.DropTable(
                name: "Parametrage_NomencaltureActivite");

            migrationBuilder.DropTable(
                name: "Parametrage_NomencaltureTypeEtab");

            migrationBuilder.DropTable(
                name: "Parametrage_RechercheMultiCritere");

            migrationBuilder.DropTable(
                name: "Passation_fiche");

            migrationBuilder.DropTable(
                name: "Passation_paraticipant");

            migrationBuilder.DropTable(
                name: "Personnel_Fiche");

            migrationBuilder.DropTable(
                name: "Personnel_FormationContinue");

            migrationBuilder.DropTable(
                name: "Proposition_fiche");

            migrationBuilder.DropTable(
                name: "Rapport_Fichier");

            migrationBuilder.DropTable(
                name: "Reclamation_Reclamation");

            migrationBuilder.DropTable(
                name: "Reclamation_ReclamationParent");

            migrationBuilder.DropTable(
                name: "Securite_AttacheInspecteur");

            migrationBuilder.DropTable(
                name: "Securite_Directeur");

            migrationBuilder.DropTable(
                name: "SECURITE_DROITACCESGROUPE");

            migrationBuilder.DropTable(
                name: "SECURITE_DROITACCESUTILISATEUR");

            migrationBuilder.DropTable(
                name: "Securite_Etablissement");

            migrationBuilder.DropTable(
                name: "Securite_Etablissement_15112020");

            migrationBuilder.DropTable(
                name: "Securite_Etablissement_historique");

            migrationBuilder.DropTable(
                name: "Securite_Etablissement_Trace");

            migrationBuilder.DropTable(
                name: "Securite_SessionUtilisateur");

            migrationBuilder.DropTable(
                name: "Securite_Siganlisation");

            migrationBuilder.DropTable(
                name: "SECURITE_TRACEUTILISATEUR");

            migrationBuilder.DropTable(
                name: "Signalisation_Fichier");

            migrationBuilder.DropTable(
                name: "Signalisation_Fichier_Rpt");

            migrationBuilder.DropTable(
                name: "Signalisation_NatureAnomalie");

            migrationBuilder.DropTable(
                name: "Signature_Fichier");

            migrationBuilder.DropTable(
                name: "Nomenclature_DedreHandicap");

            migrationBuilder.DropTable(
                name: "Nomenclature_IntergrationHandicap");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeHandicap");

            migrationBuilder.DropTable(
                name: "Nomenclature_EtatParent");

            migrationBuilder.DropTable(
                name: "Nomenclature_EtatPsycologique");

            migrationBuilder.DropTable(
                name: "Nomenclature_EtatSante");

            migrationBuilder.DropTable(
                name: "Nomenclature_LangueMaternelle");

            migrationBuilder.DropTable(
                name: "Nomenclature_Nationalite");

            migrationBuilder.DropTable(
                name: "Nomenclature_NiveauSalaire");

            migrationBuilder.DropTable(
                name: "Nomenclature_Profession");

            migrationBuilder.DropTable(
                name: "Eleve_RepartitionGroupeTrancheAge");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeInscription");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypePriseEnCharge");

            migrationBuilder.DropTable(
                name: "Etablissement_Anomalie");

            migrationBuilder.DropTable(
                name: "Nomenclature_Equipement");

            migrationBuilder.DropTable(
                name: "Etablissement_Espace");

            migrationBuilder.DropTable(
                name: "Nomenclature_CaracteristiqueEspace");

            migrationBuilder.DropTable(
                name: "Nomenclature_Infrastrcture");

            migrationBuilder.DropTable(
                name: "Nomenclature_Interventionnecessaire");

            migrationBuilder.DropTable(
                name: "Nomenclature_OrganisationAdministrative");

            migrationBuilder.DropTable(
                name: "Nomenclature_OrganisationPedagogique");

            migrationBuilder.DropTable(
                name: "Nomenclature_CaracteristiqueEspaceExterieur");

            migrationBuilder.DropTable(
                name: "Nomenclature_EmplacementEtablissement");

            migrationBuilder.DropTable(
                name: "Etablissement_Infrastructure");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeConnexionInternet");

            migrationBuilder.DropTable(
                name: "Nomenclature_Anomalie");

            migrationBuilder.DropTable(
                name: "Nomenclature_rectification");

            migrationBuilder.DropTable(
                name: "Inspection_VisiteInspection");

            migrationBuilder.DropTable(
                name: "Message_Message");

            migrationBuilder.DropTable(
                name: "Nomenclature_Constatation");

            migrationBuilder.DropTable(
                name: "Nomenclature_RubriqueInspection");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeEtatEtablissement");

            migrationBuilder.DropTable(
                name: "Nomenclature_Concerne");

            migrationBuilder.DropTable(
                name: "Nomenclature_Informateur");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeSignalisation");

            migrationBuilder.DropTable(
                name: "Parametrage_Nomenclature");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeFormation");

            migrationBuilder.DropTable(
                name: "Personnel_Personnel");

            migrationBuilder.DropTable(
                name: "Nomenclature_EtatReclamation");

            migrationBuilder.DropTable(
                name: "Nomenclature_Priorite");

            migrationBuilder.DropTable(
                name: "SECURITE_ENTITE");

            migrationBuilder.DropTable(
                name: "SECURITE_TYPEOPERATIONTRACE");

            migrationBuilder.DropTable(
                name: "Nomenclature_TrancheAge");

            migrationBuilder.DropTable(
                name: "SECURITE_UTILISATEUR");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeEquipement");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeEspace");

            migrationBuilder.DropTable(
                name: "Etablissement_FicheEtablissement");

            migrationBuilder.DropTable(
                name: "Nomenclature_EmplacementSiege");

            migrationBuilder.DropTable(
                name: "Nomenclature_RegimePropriete");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeCloture");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypePropriete");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeInspection");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeMessage");

            migrationBuilder.DropTable(
                name: "Nomenclature_CategorieRubriqueInspection");

            migrationBuilder.DropTable(
                name: "Nomenclature_SituationProfessionel");

            migrationBuilder.DropTable(
                name: "Nomenclature_Corps");

            migrationBuilder.DropTable(
                name: "Nomenclature_Fonction");

            migrationBuilder.DropTable(
                name: "Nomenclature_Genre");

            migrationBuilder.DropTable(
                name: "Nomenclature_Grade");

            migrationBuilder.DropTable(
                name: "Nomenclature_Qualite");

            migrationBuilder.DropTable(
                name: "Nomenclature_RevenuMensuel");

            migrationBuilder.DropTable(
                name: "SECURITE_PACKAGE");

            migrationBuilder.DropTable(
                name: "SECURITE_NIVEAUHIERARCHIQUE");

            migrationBuilder.DropTable(
                name: "SECURITE_GROUPEUTILISATEUR");

            migrationBuilder.DropTable(
                name: "Nomenclature_Etablissement");

            migrationBuilder.DropTable(
                name: "Nomenclature_OuvertureEtablissement");

            migrationBuilder.DropTable(
                name: "Nomenclature_Commune");

            migrationBuilder.DropTable(
                name: "Nomenclature_Delegation");

            migrationBuilder.DropTable(
                name: "Nomenclature_Diplome");

            migrationBuilder.DropTable(
                name: "Nomenclature_NiveauEtude");

            migrationBuilder.DropTable(
                name: "Nomenclature_Secteur");

            migrationBuilder.DropTable(
                name: "Nomenclature_SituationFamiliale");

            migrationBuilder.DropTable(
                name: "Nomenclature_TypeEtablissement");

            migrationBuilder.DropTable(
                name: "Nomenclature_Zone");

            migrationBuilder.DropTable(
                name: "Nomenclature_Gouvernorat");

            migrationBuilder.DropTable(
                name: "Nomenclature_District");
        }
    }
}
