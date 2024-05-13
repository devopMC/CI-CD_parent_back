using METABack.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace METABack.Entities
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public  DbSet<ActiviteFiche> ActiviteFiches { get; set; }

        public  DbSet<ActiviteParaticipant> ActiviteParaticipants { get; set; }

        public  DbSet<EleveEleveHandicap> EleveEleveHandicaps { get; set; }

        public  DbSet<EleveRepartitionEtatParent> EleveRepartitionEtatParents { get; set; }

        public  DbSet<EleveRepartitionEtatPsycologique> EleveRepartitionEtatPsycologiques { get; set; }

        public  DbSet<EleveRepartitionEtatSante> EleveRepartitionEtatSantes { get; set; }

        public  DbSet<EleveRepartitionGroupeTrancheAge> EleveRepartitionGroupeTrancheAges { get; set; }

        public  DbSet<EleveRepartitionGroupeTrancheAgeOld01122020> EleveRepartitionGroupeTrancheAgeOld01122020s { get; set; }

        public  DbSet<EleveRepartitionGroupeTrancheAgeOld02122020> EleveRepartitionGroupeTrancheAgeOld02122020s { get; set; }

        public  DbSet<EleveRepartitionLangueMaternelle> EleveRepartitionLangueMaternelles { get; set; }

        public  DbSet<EleveRepartitionNationalite> EleveRepartitionNationalites { get; set; }

        public  DbSet<EleveRepartitionNiveauEtudeMere> EleveRepartitionNiveauEtudeMeres { get; set; }

        public  DbSet<EleveRepartitionNiveauEtudePere> EleveRepartitionNiveauEtudePeres { get; set; }

        public  DbSet<EleveRepartitionNiveauSalaire> EleveRepartitionNiveauSalaires { get; set; }

        public  DbSet<EleveRepartitionProfessionMere> EleveRepartitionProfessionMeres { get; set; }

        public  DbSet<EleveRepartitionProfessionPere> EleveRepartitionProfessionPeres { get; set; }

        public  DbSet<EleveRepartitionTrancheAge> EleveRepartitionTrancheAges { get; set; }

        public  DbSet<EleveRepartitionTrancheAgeArretEtude> EleveRepartitionTrancheAgeArretEtudes { get; set; }

        public  DbSet<EleveRepartitionTrancheAgeBeneficaire> EleveRepartitionTrancheAgeBeneficaires { get; set; }

        public  DbSet<EleveRepartitionTrancheAgeOld02122020> EleveRepartitionTrancheAgeOld02122020s { get; set; }

        public  DbSet<EleveRepartitionTrancheAgeTypePriseEnCharge> EleveRepartitionTrancheAgeTypePriseEnCharges { get; set; }

        public  DbSet<EleveRepartitionTypeInscription> EleveRepartitionTypeInscriptions { get; set; }

        public  DbSet<EleveRepartitionTypePriseEnCharge> EleveRepartitionTypePriseEnCharges { get; set; }

        public  DbSet<EnfantNecessite> EnfantNecessites { get; set; }

        public  DbSet<EtablissementAnomalie> EtablissementAnomalies { get; set; }

        public  DbSet<EtablissementClub> EtablissementClubs { get; set; }

        public  DbSet<EtablissementClubGeneral> EtablissementClubGenerals { get; set; }

        public  DbSet<EtablissementClubGeneral05012022> EtablissementClubGeneral05012022s { get; set; }

        public  DbSet<EtablissementEnfantNe> EtablissementEnfantNes { get; set; }

        public  DbSet<EtablissementEquipement> EtablissementEquipements { get; set; }

        public  DbSet<EtablissementEspace> EtablissementEspaces { get; set; }

        public  DbSet<EtablissementEspaceCaracteristiqueEspace> EtablissementEspaceCaracteristiqueEspaces { get; set; }

        public  DbSet<EtablissementFicheEtablissement> EtablissementFicheEtablissements { get; set; }

        public  DbSet<EtablissementHistoriqueEtatEtab> EtablissementHistoriqueEtatEtabs { get; set; }

        public  DbSet<EtablissementInfrastructure> EtablissementInfrastructures { get; set; }

        public  DbSet<EtablissementInfrastructureAutre> EtablissementInfrastructureAutres { get; set; }

        public  DbSet<EtablissementIntervention> EtablissementInterventions { get; set; }

        public  DbSet<EtablissementLienexterne> EtablissementLienexternes { get; set; }

        public  DbSet<EtablissementOrganisationAdministrative> EtablissementOrganisationAdministratives { get; set; }

        public  DbSet<EtablissementOrganisationPedagogique> EtablissementOrganisationPedagogiques { get; set; }

        public  DbSet<EtablissementTerrain> EtablissementTerrains { get; set; }

        public  DbSet<EventFiche> EventFiches { get; set; }

        public  DbSet<EventParaticipant> EventParaticipants { get; set; }

        public  DbSet<FormationCorp> FormationCorps { get; set; }

        public  DbSet<FormationFiche> FormationFiches { get; set; }

        public  DbSet<FormationInspecteur> FormationInspecteurs { get; set; }

        public  DbSet<FormationParaticipant> FormationParaticipants { get; set; }

        public  DbSet<FormationTypeEtablissement> FormationTypeEtablissements { get; set; }

        public  DbSet<InfrastructureCaracteristiqueEspaceExterieur> InfrastructureCaracteristiqueEspaceExterieurs { get; set; }

        public  DbSet<InfrastructureEmplacement> InfrastructureEmplacements { get; set; }

        public  DbSet<InfrastructureTypeConnexionInternet> InfrastructureTypeConnexionInternets { get; set; }

        public  DbSet<InspectionClub> InspectionClubs { get; set; }

        public  DbSet<InspectionConstatation> InspectionConstatations { get; set; }

        public  DbSet<InspectionDeductionCategorieRubriqueInspection> InspectionDeductionCategorieRubriqueInspections { get; set; }

        public  DbSet<InspectionElevePresent> InspectionElevePresents { get; set; }

        public  DbSet<InspectionEnfantNe> InspectionEnfantNes { get; set; }

        public  DbSet<InspectionEquipement> InspectionEquipements { get; set; }

        public  DbSet<InspectionEspace> InspectionEspaces { get; set; }

        public  DbSet<InspectionFichierJoint> InspectionFichierJoints { get; set; }

        public  DbSet<InspectionInfoGenerale> InspectionInfoGenerales { get; set; }

        public  DbSet<InspectionInfrastructure> InspectionInfrastructures { get; set; }

        public  DbSet<InspectionInfrastructureAutre> InspectionInfrastructureAutres { get; set; }

        public DbSet<InspectionIntervention> InspectionInterventions { get; set; }

        public DbSet<InspectionLienexterne> InspectionLienexternes { get; set; }

        public  DbSet<InspectionNiveauEtude> InspectionNiveauEtudes { get; set; }

        public  DbSet<InspectionNombreEnfantTrancheAge> InspectionNombreEnfantTrancheAges { get; set; }

        public  DbSet<InspectionRecification> InspectionRecifications { get; set; }

        public  DbSet<InspectionRepartitionHandicap> InspectionRepartitionHandicaps { get; set; }

        public  DbSet<InspectionRepartitionPersonel> InspectionRepartitionPersonels { get; set; }

        public  DbSet<InspectionRepartitionPersonelFonction> InspectionRepartitionPersonelFonctions { get; set; }

        public  DbSet<InspectionRepartitionTrancheAge> InspectionRepartitionTrancheAges { get; set; }

        public  DbSet<InspectionRepartitionTrancheAgeArretEtude> InspectionRepartitionTrancheAgeArretEtudes { get; set; }

        public  DbSet<InspectionRepartitionTrancheAgeBeneficaire> InspectionRepartitionTrancheAgeBeneficaires { get; set; }

        public  DbSet<InspectionRepartitionTrancheAgeTypePriseEnCharge> InspectionRepartitionTrancheAgeTypePriseEnCharges { get; set; }

        public  DbSet<InspectionRepartitionTypePriseEnCharge> InspectionRepartitionTypePriseEnCharges { get; set; }

        public  DbSet<InspectionVisiteInspection> InspectionVisiteInspections { get; set; }

        public  DbSet<MessageFichier> MessageFichiers { get; set; }

        public  DbSet<MessageGroupe> MessageGroupes { get; set; }

        public  DbSet<MessageMessage> MessageMessages { get; set; }

        public  DbSet<MessageRecuuser> MessageRecuusers { get; set; }

        public  DbSet<MessageUser> MessageUsers { get; set; }

        public  DbSet<NomeTypeFichierJoint> NomeTypeFichierJoints { get; set; }

        public  DbSet<NomenclatureActivite> NomenclatureActivites { get; set; }

        public  DbSet<NomenclatureAnomalie> NomenclatureAnomalies { get; set; }

        public  DbSet<NomenclatureCaracteristiqueEspace> NomenclatureCaracteristiqueEspaces { get; set; }

        public  DbSet<NomenclatureCaracteristiqueEspaceExterieur> NomenclatureCaracteristiqueEspaceExterieurs { get; set; }

        public  DbSet<NomenclatureCategorieRubriqueActivite> NomenclatureCategorieRubriqueActivites { get; set; }

        public  DbSet<NomenclatureCategorieRubriqueInspection> NomenclatureCategorieRubriqueInspections { get; set; }

        public  DbSet<NomenclatureCercle> NomenclatureCercles { get; set; }

        public  DbSet<NomenclatureClub> NomenclatureClubs { get; set; }

        public  DbSet<NomenclatureCommune> NomenclatureCommunes { get; set; }

        public  DbSet<NomenclatureConcerne> NomenclatureConcernes { get; set; }

        public  DbSet<NomenclatureConstatation> NomenclatureConstatations { get; set; }

        public  DbSet<NomenclatureCorp> NomenclatureCorps { get; set; }

        public  DbSet<NomenclatureCouverture> NomenclatureCouvertures { get; set; }

        public  DbSet<NomenclatureDecisionReclamation> NomenclatureDecisionReclamations { get; set; }

        public  DbSet<NomenclatureDedreHandicap> NomenclatureDedreHandicaps { get; set; }

        public  DbSet<NomenclatureDelegation> NomenclatureDelegations { get; set; }

        public  DbSet<NomenclatureDiplome> NomenclatureDiplomes { get; set; }

        public  DbSet<NomenclatureDistrict> NomenclatureDistricts { get; set; }

        public  DbSet<NomenclatureElevePresent> NomenclatureElevePresents { get; set; }

        public  DbSet<NomenclatureEmplacementEtablissement> NomenclatureEmplacementEtablissements { get; set; }

        public  DbSet<NomenclatureEmplacementSiege> NomenclatureEmplacementSieges { get; set; }

        public  DbSet<NomenclatureEquipement> NomenclatureEquipements { get; set; }

        public  DbSet<NomenclatureEtablissement> NomenclatureEtablissements { get; set; }

        public  DbSet<NomenclatureEtatEtablissement> NomenclatureEtatEtablissements { get; set; }

        public  DbSet<NomenclatureEtatFamille> NomenclatureEtatFamilles { get; set; }

        public  DbSet<NomenclatureEtatParent> NomenclatureEtatParents { get; set; }

        public  DbSet<NomenclatureEtatPsycologique> NomenclatureEtatPsycologiques { get; set; }

        public  DbSet<NomenclatureEtatReclamation> NomenclatureEtatReclamations { get; set; }

        public  DbSet<NomenclatureEtatSante> NomenclatureEtatSantes { get; set; }

        public  DbSet<NomenclatureEtatSignalisation> NomenclatureEtatSignalisations { get; set; }

        public  DbSet<NomenclatureFonction> NomenclatureFonctions { get; set; }

        public  DbSet<NomenclatureGenerale> NomenclatureGenerales { get; set; }

        public  DbSet<NomenclatureGenre> NomenclatureGenres { get; set; }

        public  DbSet<NomenclatureGouvernorat> NomenclatureGouvernorats { get; set; }

        public  DbSet<NomenclatureGrade> NomenclatureGrades { get; set; }

        public  DbSet<NomenclatureInformateur> NomenclatureInformateurs { get; set; }

        public  DbSet<NomenclatureInfrastrcture> NomenclatureInfrastrctures { get; set; }

        public  DbSet<NomenclatureIntergrationHandicap> NomenclatureIntergrationHandicaps { get; set; }

        public  DbSet<NomenclatureInterventionnecessaire> NomenclatureInterventionnecessaires { get; set; }

        public  DbSet<NomenclatureLangueMaternelle> NomenclatureLangueMaternelles { get; set; }

        public  DbSet<NomenclatureLienExterne> NomenclatureLienExternes { get; set; }

        public  DbSet<NomenclatureMethodeSignalisation> NomenclatureMethodeSignalisations { get; set; }

        public  DbSet<NomenclatureMinistereFondatrice> NomenclatureMinistereFondatrices { get; set; }

        public  DbSet<NomenclatureNationalite> NomenclatureNationalites { get; set; }

        public  DbSet<NomenclatureNatureActivite> NomenclatureNatureActivites { get; set; }

        public  DbSet<NomenclatureNatureAnomalie> NomenclatureNatureAnomalies { get; set; }

        public  DbSet<NomenclatureNatureInvest> NomenclatureNatureInvests { get; set; }

        public  DbSet<NomenclatureNaturePere> NomenclatureNaturePeres { get; set; }

        public  DbSet<NomenclatureNatureProposition> NomenclatureNaturePropositions { get; set; }

        public  DbSet<NomenclatureNatureSignalisation> NomenclatureNatureSignalisations { get; set; }

        public  DbSet<NomenclatureNatureformateur> NomenclatureNatureformateurs { get; set; }

        public  DbSet<NomenclatureNatureformation> NomenclatureNatureformations { get; set; }

        public  DbSet<NomenclatureNiveauEleve> NomenclatureNiveauEleves { get; set; }

        public  DbSet<NomenclatureNiveauEtude> NomenclatureNiveauEtudes { get; set; }

        public  DbSet<NomenclatureNiveauFormation> NomenclatureNiveauFormations { get; set; }

        public  DbSet<NomenclatureNiveauSalaire> NomenclatureNiveauSalaires { get; set; }

        public  DbSet<NomenclatureOrganisationAdministrative> NomenclatureOrganisationAdministratives { get; set; }

        public  DbSet<NomenclatureOrganisationPedagogique> NomenclatureOrganisationPedagogiques { get; set; }

        public  DbSet<NomenclatureOuvertureEtablissement> NomenclatureOuvertureEtablissements { get; set; }

        public  DbSet<NomenclaturePriorite> NomenclaturePriorites { get; set; }

        public  DbSet<NomenclatureProfession> NomenclatureProfessions { get; set; }

        public  DbSet<NomenclatureQualite> NomenclatureQualites { get; set; }

        public  DbSet<NomenclatureRectification> NomenclatureRectifications { get; set; }

        public  DbSet<NomenclatureRegimePropriete> NomenclatureRegimeProprietes { get; set; }

        public  DbSet<NomenclatureRevenuMensuel> NomenclatureRevenuMensuels { get; set; }

        public  DbSet<NomenclatureRubriqueInspection> NomenclatureRubriqueInspections { get; set; }

        public  DbSet<NomenclatureSecteur> NomenclatureSecteurs { get; set; }

        public  DbSet<NomenclatureSecteurFormation> NomenclatureSecteurFormations { get; set; }

        public  DbSet<NomenclatureSignalisation> NomenclatureSignalisations { get; set; }

        public  DbSet<NomenclatureSituationFamiliale> NomenclatureSituationFamiliales { get; set; }

        public  DbSet<NomenclatureSituationProfessionel> NomenclatureSituationProfessionels { get; set; }

        public  DbSet<NomenclatureStatutSignalisation> NomenclatureStatutSignalisations { get; set; }

        public  DbSet<NomenclatureStructureAttache> NomenclatureStructureAttaches { get; set; }

        public  DbSet<NomenclatureTerrain> NomenclatureTerrains { get; set; }

        public  DbSet<NomenclatureTrancheAge> NomenclatureTrancheAges { get; set; }

        public  DbSet<NomenclatureTrangeAgeCouv> NomenclatureTrangeAgeCouvs { get; set; }

        public  DbSet<NomenclatureTypeAffiche> NomenclatureTypeAffiches { get; set; }

        public  DbSet<NomenclatureTypeBoolean> NomenclatureTypeBooleans { get; set; }

        public  DbSet<NomenclatureTypeCloture> NomenclatureTypeClotures { get; set; }

        public  DbSet<NomenclatureTypeConnexionInternet> NomenclatureTypeConnexionInternets { get; set; }

        public  DbSet<NomenclatureTypeEquipement> NomenclatureTypeEquipements { get; set; }

        public  DbSet<NomenclatureTypeEspace> NomenclatureTypeEspaces { get; set; }

        public  DbSet<NomenclatureTypeEtablissement> NomenclatureTypeEtablissements { get; set; }

        public  DbSet<NomenclatureTypeEtatEtablissement> NomenclatureTypeEtatEtablissements { get; set; }

        public  DbSet<NomenclatureTypeFormation> NomenclatureTypeFormations { get; set; }

        public  DbSet<NomenclatureTypeFormulaire> NomenclatureTypeFormulaires { get; set; }

        public  DbSet<NomenclatureTypeHandicap> NomenclatureTypeHandicaps { get; set; }

        public  DbSet<NomenclatureTypeInscription> NomenclatureTypeInscriptions { get; set; }

        public  DbSet<NomenclatureTypeInspection> NomenclatureTypeInspections { get; set; }

        public  DbSet<NomenclatureTypeIntervention> NomenclatureTypeInterventions { get; set; }

        public  DbSet<NomenclatureTypeMessage> NomenclatureTypeMessages { get; set; }

        public  DbSet<NomenclatureTypePriseEnCharge> NomenclatureTypePriseEnCharges { get; set; }

        public  DbSet<NomenclatureTypePropriete> NomenclatureTypeProprietes { get; set; }

        public  DbSet<NomenclatureTypeRepartition> NomenclatureTypeRepartitions { get; set; }

        public  DbSet<NomenclatureTypeSignalisation> NomenclatureTypeSignalisations { get; set; }

        public  DbSet<NomenclatureTypeproposition> NomenclatureTypepropositions { get; set; }

        public  DbSet<NomenclatureZone> NomenclatureZones { get; set; }

        public  DbSet<ParametrageAnneeScolaire> ParametrageAnneeScolaires { get; set; }

        public  DbSet<ParametrageColumn> ParametrageColumns { get; set; }

        public  DbSet<ParametrageColumnRechercheMultiCritere> ParametrageColumnRechercheMultiCriteres { get; set; }

        public  DbSet<ParametrageCubeAnalyse> ParametrageCubeAnalyses { get; set; }

        public  DbSet<ParametrageDimensionCube> ParametrageDimensionCubes { get; set; }

        public  DbSet<ParametrageGroupeNomenclature> ParametrageGroupeNomenclatures { get; set; }

        public  DbSet<ParametrageNomencaltureActivite> ParametrageNomencaltureActivites { get; set; }

        public  DbSet<ParametrageNomencaltureTypeEtab> ParametrageNomencaltureTypeEtabs { get; set; }

        public  DbSet<ParametrageNomenclature> ParametrageNomenclatures { get; set; }

        public  DbSet<ParametrageRechercheMultiCritere> ParametrageRechercheMultiCriteres { get; set; }

        public  DbSet<PassationFiche> PassationFiches { get; set; }

        public  DbSet<PassationParaticipant> PassationParaticipants { get; set; }

        public  DbSet<PersonnelFiche> PersonnelFiches { get; set; }

        public  DbSet<PersonnelFormationContinue> PersonnelFormationContinues { get; set; }

        public  DbSet<PersonnelPersonnel> PersonnelPersonnel { get; set; }

        public  DbSet<PropositionFiche> PropositionFiches { get; set; }

        public  DbSet<RapportFichier> RapportFichiers { get; set; }

        public  DbSet<ReclamationReclamation> ReclamationReclamations { get; set; }

        public  DbSet<ReclamationReclamationParent> ReclamationReclamationParents { get; set; }

        public  DbSet<SecuriteAttacheInspecteur> SecuriteAttacheInspecteurs { get; set; }
        public  DbSet<SecuriteDirecteur> SecuriteDirecteurs { get; set; }

        public  DbSet<SecuriteDroitaccesgroupe> SecuriteDroitaccesgroupes { get; set; }

        public  DbSet<SecuriteDroitaccesutilisateur> SecuriteDroitaccesutilisateurs { get; set; }

        public  DbSet<SecuriteEntite> SecuriteEntites { get; set; }

        public  DbSet<SecuriteEtablissement15112020> SecuriteEtablissement15112020s { get; set; }

        public  DbSet<SecuriteEtablissementHistorique> SecuriteEtablissementHistoriques { get; set; }

        public  DbSet<SecuriteEtablissementTrace> SecuriteEtablissementTraces { get; set; }

        public  DbSet<SecuriteGroupeutilisateur> SecuriteGroupeutilisateurs { get; set; }

        public  DbSet<SecuriteNiveauhierarchique> SecuriteNiveauhierarchiques { get; set; }

        public  DbSet<SecuritePackage> SecuritePackages { get; set; }

        public  DbSet<SecuriteSessionUtilisateur> SecuriteSessionUtilisateurs { get; set; }

        public  DbSet<SecuriteSiganlisation> SecuriteSiganlisations { get; set; }

        public  DbSet<SecuriteTraceutilisateur> SecuriteTraceutilisateurs { get; set; }

        public  DbSet<SecuriteTypeoperationtrace> SecuriteTypeoperationtraces { get; set; }

        public  DbSet<SecuriteUtilisateur> SecuriteUtilisateurs { get; set; }

        public  DbSet<SignalisationFichier> SignalisationFichiers { get; set; }

        public  DbSet<SignalisationFichierRpt> SignalisationFichierRpts { get; set; }

        public  DbSet<SignalisationNatureAnomalie> SignalisationNatureAnomalies { get; set; }

        public  DbSet<SignatureFichier> SignatureFichiers { get; set; }

        public  DbSet<ViewActivite> ViewActivites { get; set; }

        public  DbSet<ViewAnomalie> ViewAnomalies { get; set; }

        public  DbSet<ViewCommune> ViewCommunes { get; set; }

        public  DbSet<ViewEnfantS1> ViewEnfantS1s { get; set; }

        public  DbSet<ViewEnfantS10> ViewEnfantS10s { get; set; }

        public  DbSet<ViewEnfantS2> ViewEnfantS2s { get; set; }

        public  DbSet<ViewEnfantS3> ViewEnfantS3s { get; set; }

        public  DbSet<ViewEnfantS4> ViewEnfantS4s { get; set; }

        public  DbSet<ViewEnfantS5> ViewEnfantS5s { get; set; }

        public  DbSet<ViewEnfantS6> ViewEnfantS6s { get; set; }

        public  DbSet<ViewEnfantS7> ViewEnfantS7s { get; set; }

        public  DbSet<ViewEnfantS8> ViewEnfantS8s { get; set; }

        public  DbSet<ViewEnfantS9> ViewEnfantS9s { get; set; }

        public  DbSet<ViewEquipement> ViewEquipements { get; set; }

        public  DbSet<ViewEspace> ViewEspaces { get; set; }

        public  DbSet<ViewEspaceCaracteristique> ViewEspaceCaracteristiques { get; set; }

        public  DbSet<ViewEtablissement> ViewEtablissement { get; set; }

        public  DbSet<ViewEtablissementUtilisateurByGouv> ViewEtablissementUtilisateurByGouvs { get; set; }

        public  DbSet<ViewEvent> ViewEvents { get; set; }

        public  DbSet<ViewFicheEtablissement> ViewFicheEtablissements { get; set; }

        public  DbSet<ViewFormation> ViewFormations { get; set; }

        public  DbSet<ViewFormationContenue> ViewFormationContenues { get; set; }

        public  DbSet<ViewFormationNationale> ViewFormationNationales { get; set; }

        public  DbSet<ViewFormationRapport> ViewFormationRapports { get; set; }

        public  DbSet<ViewInfrastructure> ViewInfrastructures { get; set; }

        public  DbSet<ViewInfrastructureAutre> ViewInfrastructureAutres { get; set; }

        public  DbSet<ViewInspection> ViewInspections { get; set; }

        public  DbSet<ViewInspectionClub> ViewInspectionClubs { get; set; }

        public  DbSet<ViewInspectionEnfantNe> ViewInspectionEnfantNes { get; set; }

        public  DbSet<ViewInspectionEquipement> ViewInspectionEquipements { get; set; }

        public  DbSet<ViewInspectionEspace> ViewInspectionEspaces { get; set; }

        public  DbSet<ViewInspectionInfoGenerale> ViewInspectionInfoGenerales { get; set; }

        public  DbSet<ViewInspectionInfrastructure> ViewInspectionInfrastructures { get; set; }

        public  DbSet<ViewInspectionInfrastructureAutre> ViewInspectionInfrastructureAutres { get; set; }

        public  DbSet<ViewInspectionIntervention> ViewInspectionInterventions { get; set; }

        public  DbSet<ViewInspectionLienexterne> ViewInspectionLienexternes { get; set; }

        public  DbSet<ViewInspectionOrganisationAdministrative> ViewInspectionOrganisationAdministratives { get; set; }

        public  DbSet<ViewInspectionOrganisationPedagogique> ViewInspectionOrganisationPedagogiques { get; set; }

        public  DbSet<ViewInspectionRepartitionHandicap> ViewInspectionRepartitionHandicaps { get; set; }

        public  DbSet<ViewInspectionRepartitionPersonel> ViewInspectionRepartitionPersonels { get; set; }

        public  DbSet<ViewInspectionRepartitionPersonelFonction> ViewInspectionRepartitionPersonelFonctions { get; set; }

        public  DbSet<ViewInspectionRepartitionTrancheAge> ViewInspectionRepartitionTrancheAges { get; set; }

        public  DbSet<ViewInspectionRepartitionTrancheAgeArretEtude> ViewInspectionRepartitionTrancheAgeArretEtudes { get; set; }

        public  DbSet<ViewInspectionRepartitionTrancheAgeBeneficaire> ViewInspectionRepartitionTrancheAgeBeneficaires { get; set; }

        public  DbSet<ViewInspectionRepartitionTrancheAgeTypePriseEnCharge> ViewInspectionRepartitionTrancheAgeTypePriseEnCharges { get; set; }

        public  DbSet<ViewInspectionRepartitionTypePriseEnCharge> ViewInspectionRepartitionTypePriseEnCharges { get; set; }

        public  DbSet<ViewInspectionStat> ViewInspectionStats { get; set; }

        public  DbSet<ViewIntervention> ViewInterventions { get; set; }

        public  DbSet<ViewInventaireEtablissement> ViewInventaireEtablissements { get; set; }

        public  DbSet<ViewMessageDetail> ViewMessageDetails { get; set; }

        public  DbSet<ViewNomenclatureCategorieRubriqueInspection> ViewNomenclatureCategorieRubriqueInspections { get; set; }

        public  DbSet<ViewNomenclatureCommune> ViewNomenclatureCommunes { get; set; }

        public  DbSet<ViewNomenclatureDelegation> ViewNomenclatureDelegations { get; set; }

        public  DbSet<ViewNomenclatureDelegation2> ViewNomenclatureDelegation2s { get; set; }

        public  DbSet<ViewNomenclatureEquipement> ViewNomenclatureEquipements { get; set; }

        public  DbSet<ViewNomenclatureGouvernorat> ViewNomenclatureGouvernorats { get; set; }

        public  DbSet<ViewNomenclatureRubriqueInspection> ViewNomenclatureRubriqueInspections { get; set; }

        public  DbSet<ViewNomenclatureRubriqueInspection2> ViewNomenclatureRubriqueInspection2s { get; set; }

        public  DbSet<ViewPassation> ViewPassations { get; set; }

        public  DbSet<ViewProposition> ViewPropositions { get; set; }

        public  DbSet<ViewRapportActivite> ViewRapportActivites { get; set; }

        public  DbSet<ViewRapportEvent> ViewRapportEvents { get; set; }

        public  DbSet<ViewRapportPassation> ViewRapportPassations { get; set; }

        public  DbSet<ViewRepartitionClub> ViewRepartitionClubs { get; set; }

        public  DbSet<ViewRepartitionClubgeneral> ViewRepartitionClubgenerals { get; set; }

        public  DbSet<ViewRepartitionEleve> ViewRepartitionEleves { get; set; }

        public  DbSet<ViewRepartitionEleveEtatParent> ViewRepartitionEleveEtatParents { get; set; }

        public  DbSet<ViewRepartitionEleveEtatPsycologique> ViewRepartitionEleveEtatPsycologiques { get; set; }

        public  DbSet<ViewRepartitionEleveEtatSante> ViewRepartitionEleveEtatSantes { get; set; }

        public  DbSet<ViewRepartitionEleveGroupeTrancheAge> ViewRepartitionEleveGroupeTrancheAges { get; set; }

        public  DbSet<ViewRepartitionEleveHandicap> ViewRepartitionEleveHandicaps { get; set; }

        public  DbSet<ViewRepartitionEleveHandicapListe> ViewRepartitionEleveHandicapListes { get; set; }

        public  DbSet<ViewRepartitionEleveLangueMaternelle> ViewRepartitionEleveLangueMaternelles { get; set; }

        public  DbSet<ViewRepartitionEleveNationalite> ViewRepartitionEleveNationalites { get; set; }

        public  DbSet<ViewRepartitionEleveNiveauEtudeMere> ViewRepartitionEleveNiveauEtudeMeres { get; set; }

        public  DbSet<ViewRepartitionEleveNiveauEtudePere> ViewRepartitionEleveNiveauEtudePeres { get; set; }

        public  DbSet<ViewRepartitionEleveNiveauSalaireParent> ViewRepartitionEleveNiveauSalaireParents { get; set; }

        public  DbSet<ViewRepartitionElevePriseCharge> ViewRepartitionElevePriseCharges { get; set; }

        public  DbSet<ViewRepartitionEleveProfessionMere> ViewRepartitionEleveProfessionMeres { get; set; }

        public  DbSet<ViewRepartitionEleveProfessionPere> ViewRepartitionEleveProfessionPeres { get; set; }

        public  DbSet<ViewRepartitionEleveTrancheAge> ViewRepartitionEleveTrancheAges { get; set; }

        public  DbSet<ViewRepartitionEleveTrancheAgeArretEtude> ViewRepartitionEleveTrancheAgeArretEtudes { get; set; }

        public  DbSet<ViewRepartitionEleveTrancheAgeBeneficaire> ViewRepartitionEleveTrancheAgeBeneficaires { get; set; }

        public  DbSet<ViewRepartitionEleveTrancheAgeTypePrisChar> ViewRepartitionEleveTrancheAgeTypePrisChars { get; set; }

        public  DbSet<ViewRepartitionEleveTypeInscription> ViewRepartitionEleveTypeInscriptions { get; set; }

        public  DbSet<ViewRepartitionEnfantNe> ViewRepartitionEnfantNes { get; set; }

        public  DbSet<ViewRepartitionSignalisation> ViewRepartitionSignalisations { get; set; }

        public  DbSet<ViewRessourceHumain> ViewRessourceHumains { get; set; }

        public  DbSet<ViewSignalisation> ViewSignalisations { get; set; }

        public  DbSet<ViewTraceUtilisateur> ViewTraceUtilisateurs { get; set; }

        public  DbSet<ViewTraceUtilisateur1> ViewTraceUtilisateurs1 { get; set; }

        public  DbSet<ViewUtilisateur> ViewUtilisateurs { get; set; }

        public  DbSet<ViewVeetablissement> ViewVeetablissements { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SecuriteDirecteur>(entity =>
            {
                entity.HasKey(sd => sd.Id);
                entity.ToTable("Securite_Directeur");

                entity.Property(e => e.Login).IsRequired();
                entity.Property(e => e.Pwd).IsRequired(false);
                entity.Property(e => e.Nom).IsRequired(false); 
                entity.Property(e => e.Prenom).IsRequired(false); 
                entity.Property(e => e.CodeEtab).IsRequired(false); 
                entity.Property(e => e.Role).IsRequired(false);
                entity.Property(e => e.Etat).IsRequired();
            });

            modelBuilder.Entity<ActiviteFiche>(entity =>
            {
                entity.HasKey(e => e.CodeAct);

                entity.ToTable("Activite_fiche");

                entity.Property(e => e.CodeAct)
                    .ValueGeneratedNever()
                    .HasColumnName("codeAct");
                entity.Property(e => e.CodeNatAct).HasMaxLength(50);
                entity.Property(e => e.CodeSecFor).HasMaxLength(50);
                entity.Property(e => e.Codegouv).HasMaxLength(50);
                entity.Property(e => e.Codeutil).HasMaxLength(50);
                entity.Property(e => e.CodeutilM).HasMaxLength(50);
                entity.Property(e => e.Codeutilrapport)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilrapport");
                entity.Property(e => e.DateAct).HasColumnType("date");
                entity.Property(e => e.Datecreation).HasColumnType("datetime");
                entity.Property(e => e.Datemodification).HasColumnType("datetime");
                entity.Property(e => e.Daterapport)
                    .HasColumnType("datetime")
                    .HasColumnName("daterapport");
            });

            modelBuilder.Entity<ActiviteParaticipant>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Activite_paraticipant");

                entity.Property(e => e.CodeAct).HasColumnName("codeAct");
                entity.Property(e => e.CodeUtil).HasMaxLength(50);
            });

            modelBuilder.Entity<EleveEleveHandicap>(entity =>
            {
                entity.HasKey(e => new { e.NumeElev, e.CodeEtab, e.AnneScol });

                entity.ToTable("Eleve_EleveHandicap");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeDegrHand).HasMaxLength(50);
                entity.Property(e => e.CodeGenr)
                    .HasMaxLength(50)
                    .HasComment("Code genre");
                entity.Property(e => e.CodeInteHand).HasMaxLength(50);
                entity.Property(e => e.CodeTypeHand).HasMaxLength(50);
                entity.Property(e => e.DateNais).HasColumnType("date");
                entity.Property(e => e.NomPren).HasMaxLength(250);

                entity.HasOne(d => d.CodeDegrHandNavigation).WithMany(p => p.EleveEleveHandicaps)
                    .HasForeignKey(d => d.CodeDegrHand)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_EleveHandicap_Nomenclature_DedreHandicap");

                entity.HasOne(d => d.CodeGenrNavigation).WithMany(p => p.EleveEleveHandicaps)
                    .HasForeignKey(d => d.CodeGenr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_EleveHandicap_Nomenclature_Genre");

                entity.HasOne(d => d.CodeInteHandNavigation).WithMany(p => p.EleveEleveHandicaps)
                    .HasForeignKey(d => d.CodeInteHand)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_EleveHandicap_Nomenclature_IntergrationHandicap");

                entity.HasOne(d => d.CodeTypeHandNavigation).WithMany(p => p.EleveEleveHandicaps)
                    .HasForeignKey(d => d.CodeTypeHand)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_EleveHandicap_Nomenclature_TypeHandicap");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveEleveHandicaps)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_EleveHandicap_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionEtatParent>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeEtatPare });

                entity.ToTable("Eleve_RepartitionEtatParents");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeEtatPare).HasMaxLength(50);

                entity.HasOne(d => d.CodeEtatPareNavigation).WithMany(p => p.EleveRepartitionEtatParents)
                    .HasForeignKey(d => d.CodeEtatPare)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionEtatParents_Nomenclature_EtatParent");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionEtatParents)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionEtatParents_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionEtatPsycologique>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeEtatPsyc });

                entity.ToTable("Eleve_RepartitionEtatPsycologique");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeEtatPsyc).HasMaxLength(50);

                entity.HasOne(d => d.CodeEtatPsycNavigation).WithMany(p => p.EleveRepartitionEtatPsycologiques)
                    .HasForeignKey(d => d.CodeEtatPsyc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionEtatPsycologique_Nomenclature_EtatPsycologique");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionEtatPsycologiques)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionEtatPsycologique_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionEtatSante>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeEtatSant });

                entity.ToTable("Eleve_RepartitionEtatSante");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeEtatSant).HasMaxLength(50);

                entity.HasOne(d => d.CodeEtatSantNavigation).WithMany(p => p.EleveRepartitionEtatSantes)
                    .HasForeignKey(d => d.CodeEtatSant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionEtatSante_Nomenclature_EtatSante");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionEtatSantes)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionEtatSante_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionGroupeTrancheAge>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeTranAge });

                entity.ToTable("Eleve_RepartitionGroupeTrancheAge");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);

                entity.HasOne(d => d.CodeTranAgeNavigation).WithMany(p => p.EleveRepartitionGroupeTrancheAges)
                    .HasForeignKey(d => d.CodeTranAge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionGroupeTrancheAge_Nomenclature_TrancheAge1");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionGroupeTrancheAges)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionGroupeTrancheAge_Etablissement_FicheEtablissement1");
            });

            modelBuilder.Entity<EleveRepartitionGroupeTrancheAgeOld01122020>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Eleve_RepartitionGroupeTrancheAge_old01122020");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);
            });

            modelBuilder.Entity<EleveRepartitionGroupeTrancheAgeOld02122020>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Eleve_RepartitionGroupeTrancheAge_old02122020");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);
            });

            modelBuilder.Entity<EleveRepartitionLangueMaternelle>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeLangMate });

                entity.ToTable("Eleve_RepartitionLangueMaternelle");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeLangMate).HasMaxLength(50);

                entity.HasOne(d => d.CodeLangMateNavigation).WithMany(p => p.EleveRepartitionLangueMaternelles)
                    .HasForeignKey(d => d.CodeLangMate)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionLangueMaternelle_Nomenclature_LangueMaternelle");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionLangueMaternelles)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionLangueMaternelle_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionNationalite>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeNati });

                entity.ToTable("Eleve_RepartitionNationalite");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeNati).HasMaxLength(50);

                entity.HasOne(d => d.CodeNatiNavigation).WithMany(p => p.EleveRepartitionNationalites)
                    .HasForeignKey(d => d.CodeNati)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionNationalite_Nomenclature_Nationalite");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionNationalites)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionNationalite_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionNiveauEtudeMere>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeNiveEtud });

                entity.ToTable("Eleve_RepartitionNiveauEtudeMere");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeNiveEtud).HasMaxLength(50);

                entity.HasOne(d => d.CodeNiveEtudNavigation).WithMany(p => p.EleveRepartitionNiveauEtudeMeres)
                    .HasForeignKey(d => d.CodeNiveEtud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionNiveauEtudeMere_Nomenclature_NiveauEtude");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionNiveauEtudeMeres)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionNiveauEtudeMere_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionNiveauEtudePere>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeNiveEtud });

                entity.ToTable("Eleve_RepartitionNiveauEtudePere");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeNiveEtud).HasMaxLength(50);

                entity.HasOne(d => d.CodeNiveEtudNavigation).WithMany(p => p.EleveRepartitionNiveauEtudePeres)
                    .HasForeignKey(d => d.CodeNiveEtud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionNiveauEtudePere_Nomenclature_NiveauEtude");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionNiveauEtudePeres)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionNiveauEtudePere_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionNiveauSalaire>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeNiveSala });

                entity.ToTable("Eleve_RepartitionNiveauSalaire");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeNiveSala).HasMaxLength(50);

                entity.HasOne(d => d.CodeNiveSalaNavigation).WithMany(p => p.EleveRepartitionNiveauSalaires)
                    .HasForeignKey(d => d.CodeNiveSala)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionNiveauSalaire_Nomenclature_NiveauSalaire");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionNiveauSalaires)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionNiveauSalaire_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionProfessionMere>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeProf });

                entity.ToTable("Eleve_RepartitionProfessionMere");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeProf).HasMaxLength(50);

                entity.HasOne(d => d.CodeProfNavigation).WithMany(p => p.EleveRepartitionProfessionMeres)
                    .HasForeignKey(d => d.CodeProf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionProfessionMere_Nomenclature_Profession");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionProfessionMeres)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionProfessionMere_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionProfessionPere>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeProf });

                entity.ToTable("Eleve_RepartitionProfessionPere");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeProf).HasMaxLength(50);

                entity.HasOne(d => d.CodeProfNavigation).WithMany(p => p.EleveRepartitionProfessionPeres)
                    .HasForeignKey(d => d.CodeProf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionProfessionPere_Nomenclature_Profession");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionProfessionPeres)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionProfessionPere_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionTrancheAge>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeTranAge, e.NumeGrou });

                entity.ToTable("Eleve_RepartitionTrancheAge");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);

                entity.HasOne(d => d.EleveRepartitionGroupeTrancheAge).WithMany(p => p.EleveRepartitionTrancheAges)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol, d.CodeTranAge })
                    .HasConstraintName("FK_Eleve_RepartitionTrancheAge_Eleve_RepartitionGroupeTrancheAge");
            });

            modelBuilder.Entity<EleveRepartitionTrancheAgeArretEtude>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeTranAge });

                entity.ToTable("Eleve_RepartitionTrancheAgeArretEtude");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);

                entity.HasOne(d => d.CodeTranAgeNavigation).WithMany(p => p.EleveRepartitionTrancheAgeArretEtudes)
                    .HasForeignKey(d => d.CodeTranAge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionTrancheAgeArretEtude_Nomenclature_TrancheAge");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionTrancheAgeArretEtudes)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionTrancheAgeArretEtude_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionTrancheAgeBeneficaire>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeTranAge });

                entity.ToTable("Eleve_RepartitionTrancheAgeBeneficaire");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);

                entity.HasOne(d => d.CodeTranAgeNavigation).WithMany(p => p.EleveRepartitionTrancheAgeBeneficaires)
                    .HasForeignKey(d => d.CodeTranAge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionTrancheAgeBeneficaire_Nomenclature_TrancheAge");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionTrancheAgeBeneficaires)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionTrancheAgeBeneficaire_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionTrancheAgeOld02122020>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Eleve_RepartitionTrancheAge_old02122020");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);
            });

            modelBuilder.Entity<EleveRepartitionTrancheAgeTypePriseEnCharge>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeTranAge, e.CodeTypePrisChar });

                entity.ToTable("Eleve_RepartitionTrancheAgeTypePriseEnCharge");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);
                entity.Property(e => e.CodeTypePrisChar).HasMaxLength(50);

                entity.HasOne(d => d.CodeTranAgeNavigation).WithMany(p => p.EleveRepartitionTrancheAgeTypePriseEnCharges)
                    .HasForeignKey(d => d.CodeTranAge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionTrancheAgeNomenclature_TrancheAge");

                entity.HasOne(d => d.CodeTypePrisCharNavigation).WithMany(p => p.EleveRepartitionTrancheAgeTypePriseEnCharges)
                    .HasForeignKey(d => d.CodeTypePrisChar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionTrancheAgeTypePriseEnCharge_Nomenclature_TypePriseEnCharge");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionTrancheAgeTypePriseEnCharges)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionTrancheAgeTypePriseEnCharge_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionTypeInscription>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeTypeInsc });

                entity.ToTable("Eleve_RepartitionTypeInscription");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeTypeInsc).HasMaxLength(50);

                entity.HasOne(d => d.CodeTypeInscNavigation).WithMany(p => p.EleveRepartitionTypeInscriptions)
                    .HasForeignKey(d => d.CodeTypeInsc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionTypeInscription_Nomenclature_TypeInscription");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionTypeInscriptions)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionTypeInscription_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EleveRepartitionTypePriseEnCharge>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeTypePrisChar });

                entity.ToTable("Eleve_RepartitionTypePriseEnCharge");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeTypePrisChar)
                    .HasMaxLength(50)
                    .HasComment("Code Niveau d'Etude");

                entity.HasOne(d => d.CodeTypePrisCharNavigation).WithMany(p => p.EleveRepartitionTypePriseEnCharges)
                    .HasForeignKey(d => d.CodeTypePrisChar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Eleve_RepartitionTypePriseEnCharge_Nomenclature_TypePriseEnCharge");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EleveRepartitionTypePriseEnCharges)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Eleve_RepartitionTypePriseEnCharge_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EnfantNecessite>(entity =>
            {
                entity.HasKey(e => e.Idenfant).HasName("PK_Famille_necessite");

                entity.ToTable("ENFANT_necessite");

                entity.Property(e => e.Idenfant).HasColumnName("idenfant");
                entity.Property(e => e.AdrePers).HasMaxLength(250);
                entity.Property(e => e.CodeComm).HasMaxLength(50);
                entity.Property(e => e.CodeCommEtab).HasMaxLength(50);
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeDeleEtab).HasMaxLength(50);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGenr).HasMaxLength(50);
                entity.Property(e => e.CodePost).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.CodenatPere)
                    .HasMaxLength(50)
                    .HasColumnName("codenatPere");
                entity.Property(e => e.CodeutilAdd)
                    .HasMaxLength(50)
                    .HasColumnName("CodeutilADD");
                entity.Property(e => e.CodeutilSup).HasMaxLength(50);
                entity.Property(e => e.CodeutilUpdate).HasMaxLength(50);
                entity.Property(e => e.DateAjout).HasColumnType("datetime");
                entity.Property(e => e.DateNais).HasColumnType("date");
                entity.Property(e => e.Datesup).HasColumnType("datetime");
                entity.Property(e => e.Dateupdate).HasColumnType("datetime");
                entity.Property(e => e.EtatFamille).HasMaxLength(50);
                entity.Property(e => e.LieuNais).HasMaxLength(50);
                entity.Property(e => e.Nompere)
                    .HasMaxLength(50)
                    .HasColumnName("nompere");
                entity.Property(e => e.Nomprenom)
                    .HasMaxLength(50)
                    .HasColumnName("nomprenom");
                entity.Property(e => e.NumTel).HasMaxLength(50);
                entity.Property(e => e.NumeCin)
                    .HasMaxLength(10)
                    .HasColumnName("NumeCIN");
                entity.Property(e => e.Profession).HasMaxLength(50);

                entity.HasOne(d => d.CodeCommNavigation).WithMany(p => p.EnfantNecessites)
                    .HasForeignKey(d => d.CodeComm)
                    .HasConstraintName("FK_ENFANT_necessite_Nomenclature_Commune");

                entity.HasOne(d => d.CodeDeleNavigation).WithMany(p => p.EnfantNecessites)
                    .HasForeignKey(d => d.CodeDele)
                    .HasConstraintName("FK_ENFANT_necessite_Nomenclature_Delegation");

                entity.HasOne(d => d.CodeTypeEtabNavigation).WithMany(p => p.EnfantNecessites)
                    .HasForeignKey(d => d.CodeTypeEtab)
                    .HasConstraintName("FK_ENFANT_necessite_Nomenclature_TypeEtablissement");
            });

            modelBuilder.Entity<EtablissementAnomalie>(entity =>
            {
                entity.HasKey(e => new { e.Nume, e.CodeEtab, e.AnneScol });

                entity.ToTable("Etablissement_Anomalie");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.Codeutil)
                    .HasMaxLength(100)
                    .HasComment("Code commerciale (Login)")
                    .HasColumnName("CODEUTIL");
                entity.Property(e => e.DateVisi).HasColumnType("datetime");
                entity.Property(e => e.DurePrisEnCharg).HasMaxLength(250);

                entity.HasOne(d => d.CodeutilNavigation).WithMany(p => p.EtablissementAnomalies)
                    .HasForeignKey(d => d.Codeutil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Etablissement_Anomalie_SECURITE_UTILISATEUR");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EtablissementAnomalies)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Etablissement_Anomalie_Etablissement_FicheEtablissement");

                entity.HasMany(d => d.CodeAnoms).WithMany(p => p.EtablissementAnomalies)
                    .UsingEntity<Dictionary<string, object>>(
                        "EtablissementAnomalieEtablissement",
                        r => r.HasOne<NomenclatureAnomalie>().WithMany()
                            .HasForeignKey("CodeAnom")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_Etablissement_AnomalieEtablissement_Nomenclature_Anomalie"),
                        l => l.HasOne<EtablissementAnomalie>().WithMany()
                            .HasForeignKey("Nume", "CodeEtab", "AnneScol")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_Etablissement_AnomalieEtablissement_Etablissement_Anomalie"),
                        j =>
                        {
                            j.HasKey("Nume", "CodeEtab", "AnneScol", "CodeAnom");
                            j.ToTable("Etablissement_AnomalieEtablissement");
                            j.IndexerProperty<string>("CodeEtab")
                                .HasMaxLength(50)
                                .HasComment("Code établissement");
                            j.IndexerProperty<int>("AnneScol").HasComment("Année scolaire");
                            j.IndexerProperty<string>("CodeAnom")
                                .HasMaxLength(50)
                                .HasComment("Commune");
                        });
            });

            modelBuilder.Entity<EtablissementClub>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.CodeTypeClub });

                entity.ToTable("Etablissement_Club");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTypeClub).HasMaxLength(50);
                entity.Property(e => e.Nbseance).HasColumnName("nbseance");
                entity.Property(e => e.PrixClub).HasMaxLength(50);
            });

            modelBuilder.Entity<EtablissementClubGeneral>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol });

                entity.ToTable("Etablissement_ClubGeneral");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.PrixClub).HasMaxLength(50);
            });

            modelBuilder.Entity<EtablissementClubGeneral05012022>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Etablissement_ClubGeneral_05012022");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.PrixClub).HasMaxLength(50);
            });

            modelBuilder.Entity<EtablissementEnfantNe>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Etablissement_EnfantNE");

                entity.Property(e => e.Activ).HasColumnName("activ");
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeutilMod)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilMod");
                entity.Property(e => e.Codeutiladd)
                    .HasMaxLength(50)
                    .HasColumnName("codeutiladd");
                entity.Property(e => e.DateMod)
                    .HasColumnType("datetime")
                    .HasColumnName("dateMod");
                entity.Property(e => e.Datearret)
                    .HasColumnType("date")
                    .HasColumnName("datearret");
                entity.Property(e => e.Datecreation)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreation");
                entity.Property(e => e.Dateinscrit)
                    .HasColumnType("date")
                    .HasColumnName("dateinscrit");
                entity.Property(e => e.Idenfant).HasColumnName("idenfant");
                entity.Property(e => e.Motifarret)
                    .HasMaxLength(50)
                    .HasColumnName("motifarret");
            });

            modelBuilder.Entity<EtablissementEquipement>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeEqui });

                entity.ToTable("Etablissement_Equipement");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeEqui).HasMaxLength(50);

                entity.HasOne(d => d.CodeEquiNavigation).WithMany(p => p.EtablissementEquipements)
                    .HasForeignKey(d => d.CodeEqui)
                    .HasConstraintName("FK_Etablissement_Equipement_Nomenclature_Equipement");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EtablissementEquipements)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Etablissement_Equipement_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EtablissementEspace>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.NumeEspa }).HasName("PK_Etablissement_Espace_1");

                entity.ToTable("Etablissement_Espace");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeTypeEspa)
                    .HasMaxLength(50)
                    .HasComment("Code Type Equipement");

                entity.HasOne(d => d.CodeTypeEspaNavigation).WithMany(p => p.EtablissementEspaces)
                    .HasForeignKey(d => d.CodeTypeEspa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Etablissement_Espace_Nomenclature_TypeEspace");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EtablissementEspaces)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Etablissement_Espace_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EtablissementEspaceCaracteristiqueEspace>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.NumeEspa, e.CodeCaraEspa });

                entity.ToTable("Etablissement_EspaceCaracteristiqueEspace");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeCaraEspa).HasMaxLength(50);

                entity.HasOne(d => d.CodeCaraEspaNavigation).WithMany(p => p.EtablissementEspaceCaracteristiqueEspaces)
                    .HasForeignKey(d => d.CodeCaraEspa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Etablissement_EspaceCaracteristiqueEspace_Nomenclature_CaracteristiqueEspace");

                entity.HasOne(d => d.EtablissementEspace).WithMany(p => p.EtablissementEspaceCaracteristiqueEspaces)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol, d.NumeEspa })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Etablissement_EspaceCaracteristiqueEspace_Etablissement_Espace");
            });

            modelBuilder.Entity<EtablissementFicheEtablissement>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol }).HasName("PK_Etablissement_FicheEtablissement_1");

                entity.ToTable("Etablissement_FicheEtablissement");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.AdreEtab)
                    .HasMaxLength(100)
                    .HasComment("Adresse de l'établissement");
                entity.Property(e => e.Capacite)
                    .HasMaxLength(50)
                    .HasColumnName("capacite");
                entity.Property(e => e.CodeComm).HasMaxLength(50);
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeOuveEtab).HasMaxLength(50);
                entity.Property(e => e.CodePersDire)
                    .HasMaxLength(50)
                    .HasComment("Directeur de l'établissement");
                entity.Property(e => e.CodePost)
                    .HasMaxLength(50)
                    .HasComment("Code postal");
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasComment("Adresse électronique")
                    .HasColumnName("EMail");
                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .HasComment("Fax");
                entity.Property(e => e.FraiInscParAnne).HasComment("Frais inscription par année");
                entity.Property(e => e.FraiMensActiNorm).HasComment("Frais mensuel de l'activité normale");
                entity.Property(e => e.FraiMensPepi).HasComment("Frais mensuel de l'activité normale");
                entity.Property(e => e.FraiMesuCont).HasComment("Frais mensuel de l'activité normale");
                entity.Property(e => e.HeureDebutS1).HasMaxLength(10);
                entity.Property(e => e.HeureDebutS2).HasMaxLength(10);
                entity.Property(e => e.HeureFinS1).HasMaxLength(10);
                entity.Property(e => e.HeureFinS2).HasMaxLength(10);
                entity.Property(e => e.SiteWeb)
                    .HasMaxLength(200)
                    .HasComment("Site web");
                entity.Property(e => e.TeleFixe)
                    .HasMaxLength(50)
                    .HasComment("Téléphone fixe");

                entity.HasOne(d => d.CodeDeleNavigation).WithMany(p => p.EtablissementFicheEtablissements)
                    .HasForeignKey(d => d.CodeDele)
                    .HasConstraintName("FK_Etablissement_FicheEtablissement_Nomenclature_Delegation");

                entity.HasOne(d => d.CodeEtabNavigation).WithMany(p => p.EtablissementFicheEtablissements)
                    .HasForeignKey(d => d.CodeEtab)
                    .HasConstraintName("FK_Etablissement_FicheEtablissement_Nomenclature_Etablissement");

                entity.HasOne(d => d.CodeOuveEtabNavigation).WithMany(p => p.EtablissementFicheEtablissements)
                    .HasForeignKey(d => d.CodeOuveEtab)
                    .HasConstraintName("FK_Etablissement_FicheEtablissement_Nomenclature_OuvertureEtablissement");
            });

            modelBuilder.Entity<EtablissementHistoriqueEtatEtab>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Etablissement_HistoriqueEtatEtab");

                entity.Property(e => e.AdresseEtablissement).HasMaxLength(50);
                entity.Property(e => e.Cinresponsable)
                    .HasMaxLength(50)
                    .HasColumnName("CINResponsable");
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.Codeutilisateur)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilisateur");
                entity.Property(e => e.DateModif).HasColumnType("datetime");
            });

            modelBuilder.Entity<EtablissementInfrastructure>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol });

                entity.ToTable("Etablissement_Infrastructure");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.AutrEmplSieg)
                    .HasMaxLength(500)
                    .HasComment("غير ذلك حدده");
                entity.Property(e => e.Clot).HasComment("المؤسسة محاطة بسياج");
                entity.Property(e => e.CodeEmplSieg)
                    .HasMaxLength(50)
                    .HasComment("مقرّ المؤسسة");
                entity.Property(e => e.CodeRegiProp)
                    .HasMaxLength(50)
                    .HasComment("ملكية العقار");
                entity.Property(e => e.CodeTypeClot)
                    .HasMaxLength(50)
                    .HasComment("نوع السياج");
                entity.Property(e => e.CodeTypeProp)
                    .HasMaxLength(50)
                    .HasComment("نوع العقار");
                entity.Property(e => e.CodeTypeTerrain).HasMaxLength(50);
                entity.Property(e => e.ConnInte).HasComment("المؤسسة مرتبطة بشبكة الأنترنات");
                entity.Property(e => e.ExistTerrain).HasColumnName("existTerrain");
                entity.Property(e => e.HautClot).HasComment("ارتفاع السياج");
                entity.Property(e => e.PassSpecPersBesoSpec).HasComment("يوجد ممر خاص بذوي الاحتياجات الخصوصية");
                entity.Property(e => e.SurfBati).HasComment("المساحة المغطاة");
                entity.Property(e => e.SurfEspaExte).HasComment("مساحة الفضاء الخارجي");
                entity.Property(e => e.SurfTota).HasComment("المساحةالجملية");
                entity.Property(e => e.SurfaceTerrain).HasMaxLength(50);
                entity.Property(e => e.TeleFixe).HasComment("هاتف قار");

                entity.HasOne(d => d.CodeEmplSiegNavigation).WithMany(p => p.EtablissementInfrastructures)
                    .HasForeignKey(d => d.CodeEmplSieg)
                    .HasConstraintName("FK_Etablissement_Infrastructure_Nomenclature_EmplacementSiege");

                entity.HasOne(d => d.CodeRegiPropNavigation).WithMany(p => p.EtablissementInfrastructures)
                    .HasForeignKey(d => d.CodeRegiProp)
                    .HasConstraintName("FK_Etablissement_Infrastructure_Nomenclature_RegimePropriete");

                entity.HasOne(d => d.CodeTypeClotNavigation).WithMany(p => p.EtablissementInfrastructures)
                    .HasForeignKey(d => d.CodeTypeClot)
                    .HasConstraintName("FK_Etablissement_Infrastructure_Nomenclature_TypeCloture");

                entity.HasOne(d => d.CodeTypePropNavigation).WithMany(p => p.EtablissementInfrastructures)
                    .HasForeignKey(d => d.CodeTypeProp)
                    .HasConstraintName("FK_Etablissement_Infrastructure_Nomenclature_TypePropriete");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithOne(p => p.EtablissementInfrastructure)
                    .HasForeignKey<EtablissementInfrastructure>(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Etablissement_Infrastructure_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EtablissementInfrastructureAutre>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodetypeInfra });

                entity.ToTable("Etablissement_Infrastructure_Autre");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodetypeInfra).HasMaxLength(50);
                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.HasOne(d => d.CodetypeInfraNavigation).WithMany(p => p.EtablissementInfrastructureAutres)
                    .HasForeignKey(d => d.CodetypeInfra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_[Etablissement_Infrastructure_Autre_Nomenclature_Infrastrcture");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EtablissementInfrastructureAutres)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Infrastructure_Autre_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EtablissementIntervention>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeInterv });

                entity.ToTable("Etablissement_Intervention");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeInterv).HasMaxLength(50);
                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.HasOne(d => d.CodeIntervNavigation).WithMany(p => p.EtablissementInterventions)
                    .HasForeignKey(d => d.CodeInterv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Etablissement_Intervention_Nomenclature_Infrastrcture");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.EtablissementInterventions)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Etablissement_Intervention_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<EtablissementLienexterne>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeLienExterne });

                entity.ToTable("Etablissement_lienexterne");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeLienExterne).HasMaxLength(50);
                entity.Property(e => e.Checked).HasColumnName("checked");
            });

            modelBuilder.Entity<EtablissementOrganisationAdministrative>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.CodeOrgaAdmi });

                entity.ToTable("Etablissement_OrganisationAdministrative");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeOrgaAdmi)
                    .HasMaxLength(50)
                    .HasComment("Commune");
                entity.Property(e => e.Ajour).HasColumnName("AJour");

                entity.HasOne(d => d.CodeOrgaAdmiNavigation).WithMany(p => p.EtablissementOrganisationAdministratives)
                    .HasForeignKey(d => d.CodeOrgaAdmi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Etablissement_OrganisationAdministrative_Nomenclature_OrganisationAdministrative");
            });

            modelBuilder.Entity<EtablissementOrganisationPedagogique>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.CodeOrgaPeda }).HasName("PK_Etablissement_OrganisationPedagogique_1");

                entity.ToTable("Etablissement_OrganisationPedagogique");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeOrgaPeda)
                    .HasMaxLength(50)
                    .HasComment("Commune");
                entity.Property(e => e.Ajour).HasColumnName("AJour");

                entity.HasOne(d => d.CodeOrgaPedaNavigation).WithMany(p => p.EtablissementOrganisationPedagogiques)
                    .HasForeignKey(d => d.CodeOrgaPeda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Etablissement_OrganisationPedagogique_Nomenclature_OrganisationPedagogique");
            });

            modelBuilder.Entity<EtablissementTerrain>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.CodeTerrain });

                entity.ToTable("Etablissement_Terrain");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTerrain).HasMaxLength(50);
            });

            modelBuilder.Entity<EventFiche>(entity =>
            {
                entity.HasKey(e => e.CodeEvent);

                entity.ToTable("Event_fiche");

                entity.Property(e => e.CodeEvent)
                    .ValueGeneratedNever()
                    .HasColumnName("codeEvent");
                entity.Property(e => e.CodeNivFor).HasMaxLength(50);
                entity.Property(e => e.CodeSecFor).HasMaxLength(50);
                entity.Property(e => e.Codegouv).HasMaxLength(50);
                entity.Property(e => e.Codeutil).HasMaxLength(50);
                entity.Property(e => e.CodeutilM).HasMaxLength(50);
                entity.Property(e => e.Codeutilrapport)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilrapport");
                entity.Property(e => e.DateEvent).HasColumnType("date");
                entity.Property(e => e.Datecreation).HasColumnType("datetime");
                entity.Property(e => e.Datemodification).HasColumnType("datetime");
                entity.Property(e => e.Daterapport)
                    .HasColumnType("datetime")
                    .HasColumnName("daterapport");
                entity.Property(e => e.InvesEvent).HasMaxLength(50);
                entity.Property(e => e.PrixEvent).HasMaxLength(50);
            });

            modelBuilder.Entity<EventParaticipant>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Event_paraticipant");

                entity.Property(e => e.CodeEvent).HasColumnName("codeEvent");
                entity.Property(e => e.CodeUtil).HasMaxLength(50);
            });

            modelBuilder.Entity<FormationCorp>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Formation_Corps");

                entity.Property(e => e.CodeCorps).HasMaxLength(50);
                entity.Property(e => e.Codeformation).HasColumnName("codeformation");
            });

            modelBuilder.Entity<FormationFiche>(entity =>
            {
                entity.HasKey(e => e.Codeformation).HasName("PK_Formation_Fiche");

                entity.ToTable("Formation_fiche");

                entity.Property(e => e.Codeformation)
                    .ValueGeneratedNever()
                    .HasColumnName("codeformation");
                entity.Property(e => e.CodeCerc).HasMaxLength(50);
                entity.Property(e => e.CodeNatFor).HasMaxLength(50);
                entity.Property(e => e.CodeNatFormateur).HasMaxLength(50);
                entity.Property(e => e.CodeNivFor).HasMaxLength(50);
                entity.Property(e => e.CodeSecFor).HasMaxLength(50);
                entity.Property(e => e.Codegouv).HasMaxLength(50);
                entity.Property(e => e.Codeutil).HasMaxLength(50);
                entity.Property(e => e.CodeutilM).HasMaxLength(50);
                entity.Property(e => e.Codeutilrapport)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilrapport");
                entity.Property(e => e.Datecreation).HasColumnType("datetime");
                entity.Property(e => e.Dateformation).HasColumnType("date");
                entity.Property(e => e.Datemodification).HasColumnType("datetime");
                entity.Property(e => e.Daterapport)
                    .HasColumnType("datetime")
                    .HasColumnName("daterapport");
                entity.Property(e => e.Inspecteur).HasMaxLength(50);
                entity.Property(e => e.InvesFormation).HasMaxLength(50);
                entity.Property(e => e.NomFormateur).HasMaxLength(50);
                entity.Property(e => e.PrixFormation).HasMaxLength(50);
            });

            modelBuilder.Entity<FormationInspecteur>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Formation_Inspecteur");

                entity.Property(e => e.CodeUtil).HasMaxLength(50);
                entity.Property(e => e.Codeformation).HasColumnName("codeformation");
            });

            modelBuilder.Entity<FormationParaticipant>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Formation_paraticipant");

                entity.Property(e => e.CodeUtil).HasMaxLength(50);
                entity.Property(e => e.Codeformation).HasColumnName("codeformation");
            });

            modelBuilder.Entity<FormationTypeEtablissement>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Formation_TypeEtablissement");

                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.Codeformation).HasColumnName("codeformation");
            });

            modelBuilder.Entity<InfrastructureCaracteristiqueEspaceExterieur>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Infrastructure_CaracteristiqueEspaceExterieur");

                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeCaraEspaExte)
                    .HasMaxLength(50)
                    .HasComment("خصائص الفضاء الخارجي");
                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");

                entity.HasOne(d => d.CodeCaraEspaExteNavigation).WithMany()
                    .HasForeignKey(d => d.CodeCaraEspaExte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Infrastructure_CaracteristiqueEspaceExterieur_Nomenclature_CaracteristiqueEspaceExterieur");

                entity.HasOne(d => d.EtablissementInfrastructure).WithMany()
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Infrastructure_CaracteristiqueEspaceExterieur_Etablissement_Infrastructure");
            });

            modelBuilder.Entity<InfrastructureEmplacement>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Infrastructure_Emplacement");

                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeEmpl)
                    .HasMaxLength(50)
                    .HasComment("خصائص الفضاء الخارجي");
                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");

                entity.HasOne(d => d.CodeEmplNavigation).WithMany()
                    .HasForeignKey(d => d.CodeEmpl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Infrastructure_Emplacement_Nomenclature_Emplacement");

                entity.HasOne(d => d.EtablissementInfrastructure).WithMany()
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Infrastructure_Emplacement_Etablissement_Infrastructure");
            });

            modelBuilder.Entity<InfrastructureTypeConnexionInternet>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Infrastructure_TypeConnexionInternet");

                entity.Property(e => e.AnneScol).HasComment("Année scolaire");
                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.CodeTypeConnInte)
                    .HasMaxLength(50)
                    .HasComment("خصائص الفضاء الخارجي");

                entity.HasOne(d => d.CodeTypeConnInteNavigation).WithMany()
                    .HasForeignKey(d => d.CodeTypeConnInte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Infrastructure_TypeConnexionInternet_Nomenclature_TypeConnexionInternet");

                entity.HasOne(d => d.EtablissementInfrastructure).WithMany()
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Infrastructure_TypeConnexionInternet_Etablissement_Infrastructure");
            });

            modelBuilder.Entity<InspectionClub>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Inspection_Club");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTypeClub).HasMaxLength(50);
                entity.Property(e => e.LibeClub).HasMaxLength(250);
                entity.Property(e => e.Nbseance).HasColumnName("nbseance");
                entity.Property(e => e.PrixClub).HasMaxLength(50);
            });

            modelBuilder.Entity<InspectionConstatation>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.CodeRubrInsp });

                entity.ToTable("Inspection_Constatation");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeRubrInsp).HasMaxLength(50);
                entity.Property(e => e.CodeCons).HasMaxLength(50);

                entity.HasOne(d => d.CodeRubrInspNavigation).WithMany(p => p.InspectionConstatations)
                    .HasForeignKey(d => d.CodeRubrInsp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inspection_Constatation_Nomenclature_RubriqueInspection");

                entity.HasOne(d => d.InspectionVisiteInspection).WithMany(p => p.InspectionConstatations)
                    .HasForeignKey(d => new { d.NumeVisiInsp, d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Inspection_Constatation_Inspection_VisiteInspection");
            });

            modelBuilder.Entity<InspectionDeductionCategorieRubriqueInspection>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.CodeCateRubrInsp });

                entity.ToTable("Inspection_DeductionCategorieRubriqueInspection");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeCateRubrInsp).HasMaxLength(50);

                entity.HasOne(d => d.CodeCateRubrInspNavigation).WithMany(p => p.InspectionDeductionCategorieRubriqueInspections)
                    .HasForeignKey(d => d.CodeCateRubrInsp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inspection_DeductionCategorieRubriqueInspection_Nomenclature_CategorieRubriqueInspection");

                entity.HasOne(d => d.InspectionVisiteInspection).WithMany(p => p.InspectionDeductionCategorieRubriqueInspections)
                    .HasForeignKey(d => new { d.NumeVisiInsp, d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Inspection_DeductionCategorieRubriqueInspection_Inspection_VisiteInspection");
            });

            modelBuilder.Entity<InspectionElevePresent>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.CodeElevePresent });

                entity.ToTable("Inspection_ElevePresent");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeElevePresent).HasMaxLength(50);
                entity.Property(e => e.LibeElevePresent).HasMaxLength(250);
            });

            modelBuilder.Entity<InspectionEnfantNe>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Inspection_EnfantNE");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.DateNais).HasMaxLength(30);
                entity.Property(e => e.Dateinscrit)
                    .HasMaxLength(30)
                    .HasColumnName("dateinscrit");
                entity.Property(e => e.Idenfant).HasColumnName("idenfant");
                entity.Property(e => e.Nompere)
                    .HasMaxLength(50)
                    .HasColumnName("nompere");
                entity.Property(e => e.Nomprenom)
                    .HasMaxLength(50)
                    .HasColumnName("nomprenom");
                entity.Property(e => e.NumTel).HasMaxLength(50);
            });

            modelBuilder.Entity<InspectionEquipement>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.NumeEqui });

                entity.ToTable("Inspection_Equipement");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEqui).HasMaxLength(1000);

                entity.HasOne(d => d.InspectionVisiteInspection).WithMany(p => p.InspectionEquipements)
                    .HasForeignKey(d => new { d.NumeVisiInsp, d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Inspection_Equipement_Inspection_VisiteInspection");
            });

            modelBuilder.Entity<InspectionEspace>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.NumeEspa });

                entity.ToTable("Inspection_espace");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);

                entity.HasOne(d => d.InspectionVisiteInspection).WithMany(p => p.InspectionEspaces)
                    .HasForeignKey(d => new { d.NumeVisiInsp, d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Inspection_espace_Inspection_VisiteInspection");
            });

            modelBuilder.Entity<InspectionFichierJoint>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.NumeFichJoin });

                entity.ToTable("Inspection_FichierJoint");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeUtil).HasMaxLength(50);
                entity.Property(e => e.DateOper).HasColumnType("datetime");
                entity.Property(e => e.PhysNameFile).HasMaxLength(250);
                entity.Property(e => e.UploNameFile).HasMaxLength(250);
            });

            modelBuilder.Entity<InspectionInfoGenerale>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol });

                entity.ToTable("Inspection_InfoGenerale");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.AdreEtab).HasMaxLength(100);
                entity.Property(e => e.CodePost).HasMaxLength(50);
                entity.Property(e => e.DateCrea).HasColumnType("datetime");
                entity.Property(e => e.DateDepoCahiChar).HasColumnType("datetime");
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.NomPrenDire).HasMaxLength(250);
                entity.Property(e => e.NomPrenFond).HasMaxLength(50);
                entity.Property(e => e.NumePiecIden).HasMaxLength(50);
                entity.Property(e => e.NumePiecIdenDire).HasMaxLength(10);
                entity.Property(e => e.TeleFixe).HasMaxLength(50);

                entity.HasOne(d => d.InspectionVisiteInspection).WithOne(p => p.InspectionInfoGenerale)
                    .HasForeignKey<InspectionInfoGenerale>(d => new { d.NumeVisiInsp, d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Inspection_InfoGenerale_Inspection_VisiteInspection");
            });

            modelBuilder.Entity<InspectionInfrastructure>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Inspection_Infrastructure");

                entity.Property(e => e.AutrEmplSieg).HasMaxLength(500);
                entity.Property(e => e.CodeEmplSieg).HasMaxLength(50);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.ExistTerrain).HasColumnName("existTerrain");
                entity.Property(e => e.LibeCaraEspaExte).HasMaxLength(250);
                entity.Property(e => e.LibeEmpl).HasMaxLength(250);
                entity.Property(e => e.LibeEmplSieg).HasMaxLength(250);
                entity.Property(e => e.LibeTerrain).HasMaxLength(50);
                entity.Property(e => e.LibeTypeClot).HasMaxLength(250);
                entity.Property(e => e.LibeTypeConnInte).HasMaxLength(250);
                entity.Property(e => e.LibeTypeProp).HasMaxLength(250);
                entity.Property(e => e.SurfaceTerrain).HasMaxLength(50);

                entity.HasOne(d => d.InspectionVisiteInspection).WithMany()
                    .HasForeignKey(d => new { d.NumeVisiInsp, d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Inspection_Infrastructure_Inspection_VisiteInspection");
            });

            modelBuilder.Entity<InspectionInfrastructureAutre>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Inspection_Infrastructure_Autre");

                entity.Property(e => e.Checked).HasColumnName("checked");
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodetypeInfra).HasMaxLength(50);
                entity.Property(e => e.Lbchecked)
                    .HasMaxLength(3)
                    .HasColumnName("LBChecked");
                entity.Property(e => e.LibeInfrastrcture).HasMaxLength(250);
            });

            modelBuilder.Entity<InspectionIntervention>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Inspection_intervention");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeInterv).HasMaxLength(50);
                entity.Property(e => e.CodeTypeInterv).HasMaxLength(50);
                entity.Property(e => e.LibeInterv).HasMaxLength(250);
                entity.Property(e => e.LibeTypeInterv).HasMaxLength(250);
            });

            modelBuilder.Entity<InspectionLienexterne>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Inspection_Lienexterne");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeLienExterne).HasMaxLength(50);
                entity.Property(e => e.LibeLienExterne).HasMaxLength(250);
            });

            modelBuilder.Entity<InspectionNiveauEtude>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.CodeNivEle });

                entity.ToTable("Inspection_NiveauEtude");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeNivEle).HasMaxLength(50);
                entity.Property(e => e.LibeNivEle).HasMaxLength(250);
            });

            modelBuilder.Entity<InspectionNombreEnfantTrancheAge>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.CodeTranAge });

                entity.ToTable("Inspection_NombreEnfantTrancheAge");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);

                entity.HasOne(d => d.CodeTranAgeNavigation).WithMany(p => p.InspectionNombreEnfantTrancheAges)
                    .HasForeignKey(d => d.CodeTranAge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inspection_NombreEnfantTrancheAge_Nomenclature_TrancheAge");

                entity.HasOne(d => d.InspectionVisiteInspection).WithMany(p => p.InspectionNombreEnfantTrancheAges)
                    .HasForeignKey(d => new { d.NumeVisiInsp, d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Inspection_NombreEnfantTrancheAge_Inspection_VisiteInspection");
            });

            modelBuilder.Entity<InspectionRecification>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.CodeRect });

                entity.ToTable("Inspection_Recifications");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeRect).HasMaxLength(50);

                entity.HasOne(d => d.CodeRectNavigation).WithMany(p => p.InspectionRecifications)
                    .HasForeignKey(d => d.CodeRect)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inspection_Recifications_Nomenclature_rectification");

                entity.HasOne(d => d.InspectionVisiteInspection).WithMany(p => p.InspectionRecifications)
                    .HasForeignKey(d => new { d.NumeVisiInsp, d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Inspection_Recifications_Inspection_VisiteInspection");
            });

            modelBuilder.Entity<InspectionRepartitionHandicap>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.LibeTypeHand });

                entity.ToTable("Inspection_RepartitionHandicap");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeHand).HasMaxLength(250);

                entity.HasOne(d => d.InspectionVisiteInspection).WithMany(p => p.InspectionRepartitionHandicaps)
                    .HasForeignKey(d => new { d.NumeVisiInsp, d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Inspection_RepartitionHandicap_Inspection_VisiteInspection");
            });

            modelBuilder.Entity<InspectionRepartitionPersonel>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.IdenUniq });

                entity.ToTable("Inspection_RepartitionPersonel");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.DateNais).HasColumnType("date");
                entity.Property(e => e.Dateaffectation)
                    .HasColumnType("date")
                    .HasColumnName("dateaffectation");
                entity.Property(e => e.DatenotePead)
                    .HasMaxLength(50)
                    .HasColumnName("datenotePead");
                entity.Property(e => e.Daterecrutement)
                    .HasColumnType("date")
                    .HasColumnName("daterecrutement");
                entity.Property(e => e.Daterespons)
                    .HasColumnType("date")
                    .HasColumnName("daterespons");
                entity.Property(e => e.IdenUniqMatrCnss).HasMaxLength(50);
                entity.Property(e => e.LibeFonc).HasMaxLength(50);
                entity.Property(e => e.LibeGenr).HasMaxLength(50);
                entity.Property(e => e.LibeGrad).HasMaxLength(250);
                entity.Property(e => e.LibeNiveEtud).HasMaxLength(50);
                entity.Property(e => e.NomPren).HasMaxLength(250);
                entity.Property(e => e.NotePead)
                    .HasMaxLength(50)
                    .HasColumnName("notePead");
                entity.Property(e => e.StructureAttache).HasMaxLength(50);
            });

            modelBuilder.Entity<InspectionRepartitionPersonelFonction>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.LibeFonc });

                entity.ToTable("Inspection_RepartitionPersonelFonction");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeFonc).HasMaxLength(50);

                entity.HasOne(d => d.InspectionVisiteInspection).WithMany(p => p.InspectionRepartitionPersonelFonctions)
                    .HasForeignKey(d => new { d.NumeVisiInsp, d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Inspection_RepartitionPersonelFonction_Inspection_VisiteInspection");
            });

            modelBuilder.Entity<InspectionRepartitionTrancheAge>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol, e.LibeTranAge });

                entity.ToTable("Inspection_RepartitionTrancheAge");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTranAge).HasMaxLength(250);
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);

                entity.HasOne(d => d.InspectionVisiteInspection).WithMany(p => p.InspectionRepartitionTrancheAges)
                    .HasForeignKey(d => new { d.NumeVisiInsp, d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Inspection_RepartitionTrancheAge_Inspection_VisiteInspection");
            });

            modelBuilder.Entity<InspectionRepartitionTrancheAgeArretEtude>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Inspection_RepartitionTrancheAgeArretEtude");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);
                entity.Property(e => e.LibeTranAge).HasMaxLength(250);
            });

            modelBuilder.Entity<InspectionRepartitionTrancheAgeBeneficaire>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Inspection_RepartitionTrancheAgeBeneficaire");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);
                entity.Property(e => e.LibeTranAge).HasMaxLength(250);
            });

            modelBuilder.Entity<InspectionRepartitionTrancheAgeTypePriseEnCharge>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Inspection_RepartitionTrancheAgeTypePriseEnCharge");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);
                entity.Property(e => e.CodeTypePrisChar).HasMaxLength(50);
                entity.Property(e => e.LibeTranAge).HasMaxLength(250);
                entity.Property(e => e.LibeTypePrisChar)
                    .HasMaxLength(50)
                    .HasColumnName("libeTypePrisChar");
            });

            modelBuilder.Entity<InspectionRepartitionTypePriseEnCharge>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Inspection_RepartitionTypePriseEnCharge");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTypePrisChar).HasMaxLength(50);
                entity.Property(e => e.LibeTypePrisChar)
                    .HasMaxLength(50)
                    .HasColumnName("libeTypePrisChar");
            });

            modelBuilder.Entity<InspectionVisiteInspection>(entity =>
            {
                entity.HasKey(e => new { e.NumeVisiInsp, e.CodeEtab, e.AnneScol });

                entity.ToTable("Inspection_VisiteInspection");

                entity.HasIndex(e => new { e.CodeEtab, e.AnneScol }, "index_Etab_anne");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.Capacite)
                    .HasMaxLength(50)
                    .HasColumnName("capacite");
                entity.Property(e => e.Chefvue)
                    .HasMaxLength(50)
                    .HasColumnName("chefvue");
                entity.Property(e => e.CodeActivite).HasMaxLength(50);
                entity.Property(e => e.CodeEtabPers).HasMaxLength(50);
                entity.Property(e => e.CodeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTypeInsp).HasMaxLength(50);
                entity.Property(e => e.CodeutilConfirmation)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilConfirmation");
                entity.Property(e => e.DateProcVisi).HasColumnType("date");
                entity.Property(e => e.DateVisiInsp).HasColumnType("date");
                entity.Property(e => e.DateconfirmationMaj)
                    .HasColumnType("date")
                    .HasColumnName("dateconfirmationMAJ");
                entity.Property(e => e.DatedemandeMaj)
                    .HasColumnType("date")
                    .HasColumnName("datedemandeMAJ");
                entity.Property(e => e.Datemail)
                    .HasColumnType("datetime")
                    .HasColumnName("datemail");
                entity.Property(e => e.Datesaisie)
                    .HasColumnType("date")
                    .HasColumnName("datesaisie");
                entity.Property(e => e.Datevalidation)
                    .HasColumnType("datetime")
                    .HasColumnName("datevalidation");
                entity.Property(e => e.Datevue)
                    .HasColumnType("datetime")
                    .HasColumnName("datevue");
                entity.Property(e => e.DeduGene).UseCollation("Arabic_CI_AS");
                entity.Property(e => e.DemandeMaj)
                    .HasDefaultValueSql("((0))")
                    .HasColumnName("DemandeMAJ");
                entity.Property(e => e.FinSaisie).HasMaxLength(50);
                entity.Property(e => e.Inspecteur2).HasMaxLength(50);
                entity.Property(e => e.Inspecteurvalide)
                    .HasMaxLength(50)
                    .HasColumnName("inspecteurvalide");
                entity.Property(e => e.MatrInsp).HasMaxLength(50);
                entity.Property(e => e.MembCommTitu).HasMaxLength(250);
                entity.Property(e => e.MotifMaj).HasColumnName("MotifMAJ");
                entity.Property(e => e.NoteEnLettre).HasMaxLength(250);
                entity.Property(e => e.PriseRemaq)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((0))");
                entity.Property(e => e.RemaSuivActi).HasColumnName("RemaSuiv_Acti");
                entity.Property(e => e.RemaSuivCondSecu).HasColumnName("RemaSuiv_CondSecu");
                entity.Property(e => e.RemaSuivInfr).HasColumnName("RemaSuiv_Infr");
                entity.Property(e => e.RemaSuivPers).HasColumnName("RemaSuiv_Pers");
                entity.Property(e => e.RemaSuivProgPeda).HasColumnName("RemaSuiv_ProgPeda");
                entity.Property(e => e.RemaSuivSujet)
                    .HasMaxLength(100)
                    .HasColumnName("RemaSuiv_Sujet");
                entity.Property(e => e.Statut).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CodeTypeInspNavigation).WithMany(p => p.InspectionVisiteInspections)
                    .HasForeignKey(d => d.CodeTypeInsp)
                    .HasConstraintName("FK_Inspection_VisiteInspection_Nomenclature_TypeInspection");

                entity.HasMany(d => d.CodeAnoms).WithMany(p => p.InspectionVisiteInspections)
                    .UsingEntity<Dictionary<string, object>>(
                        "InspectionAnomalie",
                        r => r.HasOne<NomenclatureAnomalie>().WithMany()
                            .HasForeignKey("CodeAnom")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_Inspection_Anomalie_Nomenclature_Anomalie"),
                        l => l.HasOne<InspectionVisiteInspection>().WithMany()
                            .HasForeignKey("NumeVisiInsp", "CodeEtab", "AnneScol")
                            .HasConstraintName("FK_Inspection_Anomalie_Inspection_VisiteInspection"),
                        j =>
                        {
                            j.HasKey("NumeVisiInsp", "CodeEtab", "AnneScol", "CodeAnom");
                            j.ToTable("Inspection_Anomalie");
                            j.IndexerProperty<string>("CodeEtab").HasMaxLength(50);
                            j.IndexerProperty<string>("CodeAnom")
                                .HasMaxLength(50)
                                .HasComment("Commune");
                        });
            });

            modelBuilder.Entity<MessageFichier>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Message_Fichier");

                entity.Property(e => e.Extension)
                    .HasMaxLength(50)
                    .HasColumnName("extension");
                entity.Property(e => e.IdMessage).HasColumnName("idMessage");
                entity.Property(e => e.Nomfichier)
                    .HasMaxLength(250)
                    .HasColumnName("nomfichier");
                entity.Property(e => e.Observation).HasMaxLength(50);

                entity.HasOne(d => d.IdMessageNavigation).WithMany()
                    .HasForeignKey(d => d.IdMessage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_Fichier_Message_Message");
            });

            modelBuilder.Entity<MessageGroupe>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Message_Groupe");

                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeGroup).HasMaxLength(50);
                entity.Property(e => e.IdMessage).HasColumnName("idMessage");
                entity.Property(e => e.Observation).HasMaxLength(50);

                entity.HasOne(d => d.IdMessageNavigation).WithMany()
                    .HasForeignKey(d => d.IdMessage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_Groupe_Message_Message");
            });

            modelBuilder.Entity<MessageMessage>(entity =>
            {
                entity.HasKey(e => e.IdMessage);

                entity.ToTable("Message_Message");

                entity.Property(e => e.IdMessage).HasColumnName("idMessage");
                entity.Property(e => e.CodeTypeM).HasMaxLength(50);
                entity.Property(e => e.CodeUtilFrom).HasMaxLength(50);
                entity.Property(e => e.Codeutil)
                    .HasMaxLength(50)
                    .HasColumnName("codeutil");
                entity.Property(e => e.DateEnvoi).HasColumnType("datetime");
                entity.Property(e => e.IdmessageParent).HasColumnName("Idmessage_Parent");
                entity.Property(e => e.Text).HasColumnName("text");

                entity.HasOne(d => d.CodeTypeMNavigation).WithMany(p => p.MessageMessages)
                    .HasForeignKey(d => d.CodeTypeM)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_Message_Nomenclature_TypeMessage");
            });

            modelBuilder.Entity<MessageRecuuser>(entity =>
            {
                entity.HasKey(e => new { e.Idmessage, e.CodeUtil });

                entity.ToTable("message_recuuser");

                entity.Property(e => e.Idmessage).HasColumnName("idmessage");
                entity.Property(e => e.CodeUtil).HasMaxLength(50);
                entity.Property(e => e.Daterecu)
                    .HasColumnType("datetime")
                    .HasColumnName("daterecu");
            });

            modelBuilder.Entity<MessageUser>(entity =>
            {
                entity.HasKey(e => new { e.IdMessage, e.CodeUtil });

                entity.ToTable("Message_User");

                entity.Property(e => e.IdMessage).HasColumnName("idMessage");
                entity.Property(e => e.CodeUtil).HasMaxLength(50);
                entity.Property(e => e.Datereception).HasColumnType("datetime");
                entity.Property(e => e.Lu)
                    .HasDefaultValueSql("((0))")
                    .HasColumnName("lu");
                entity.Property(e => e.Observation).HasMaxLength(50);

                entity.HasOne(d => d.IdMessageNavigation).WithMany(p => p.MessageUsers)
                    .HasForeignKey(d => d.IdMessage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_User_Message_Message");
            });

            modelBuilder.Entity<NomeTypeFichierJoint>(entity =>
            {
                entity.HasKey(e => e.CodeTypefich);

                entity.ToTable("Nome_TypeFichierJoint");

                entity.Property(e => e.CodeTypefich)
                    .HasMaxLength(10)
                    .IsFixedLength();
                entity.Property(e => e.IconTypeFich)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("iconTypeFich");
                entity.Property(e => e.LibeTypeFich)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NomenclatureActivite>(entity =>
            {
                entity.HasKey(e => e.Codeactivite);

                entity.ToTable("Nomenclature_activite");

                entity.Property(e => e.Codeactivite).HasMaxLength(50);
                entity.Property(e => e.Afficheeleve).HasColumnName("afficheeleve");
                entity.Property(e => e.Afficheniveau).HasColumnName("afficheniveau");
                entity.Property(e => e.Libeactivite).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureAnomalie>(entity =>
            {
                entity.HasKey(e => e.CodeAnom);

                entity.ToTable("Nomenclature_Anomalie");

                entity.Property(e => e.CodeAnom)
                    .HasMaxLength(50)
                    .HasComment("Commune");
                entity.Property(e => e.LibeAnom).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureCaracteristiqueEspace>(entity =>
            {
                entity.HasKey(e => e.CodeCaraEspa);

                entity.ToTable("Nomenclature_CaracteristiqueEspace");

                entity.Property(e => e.CodeCaraEspa).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEspa).HasMaxLength(50);
                entity.Property(e => e.LibeCaraEspa).HasMaxLength(250);

                entity.HasOne(d => d.CodeTypeEspaNavigation).WithMany(p => p.NomenclatureCaracteristiqueEspaces)
                    .HasForeignKey(d => d.CodeTypeEspa)
                    .HasConstraintName("FK_Nomenclature_CaracteristiqueEspace_Nomenclature_TypeEspace");
            });

            modelBuilder.Entity<NomenclatureCaracteristiqueEspaceExterieur>(entity =>
            {
                entity.HasKey(e => e.CodeCaraEspaExte);

                entity.ToTable("Nomenclature_CaracteristiqueEspaceExterieur");

                entity.Property(e => e.CodeCaraEspaExte)
                    .HasMaxLength(50)
                    .HasComment("خصائص الفضاء الخارجي");
                entity.Property(e => e.LibeCaraEspaExte).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureCategorieRubriqueActivite>(entity =>
            {
                entity.HasKey(e => new { e.Codeactivite, e.CodeCateRubrInsp });

                entity.ToTable("Nomenclature_CategorieRubriqueActivite");

                entity.Property(e => e.Codeactivite).HasMaxLength(50);
                entity.Property(e => e.CodeCateRubrInsp).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureCategorieRubriqueInspection>(entity =>
            {
                entity.HasKey(e => e.CodeCateRubrInsp);

                entity.ToTable("Nomenclature_CategorieRubriqueInspection");

                entity.Property(e => e.CodeCateRubrInsp).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code type établissement");
                entity.Property(e => e.LibeCateRubrInsp).HasMaxLength(250);

                entity.HasOne(d => d.CodeTypeEtabNavigation).WithMany(p => p.NomenclatureCategorieRubriqueInspections)
                    .HasForeignKey(d => d.CodeTypeEtab)
                    .HasConstraintName("FK_Nomenclature_CategorieRubriqueInspection_Nomenclature_TypeEtablissement");
            });

            modelBuilder.Entity<NomenclatureCercle>(entity =>
            {
                entity.HasKey(e => e.CodeCerc);

                entity.ToTable("Nomenclature_Cercle");

                entity.Property(e => e.CodeCerc).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeCerc).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureClub>(entity =>
            {
                entity.HasKey(e => e.CodeClub);

                entity.ToTable("Nomenclature_Club");

                entity.Property(e => e.CodeClub).HasMaxLength(50);
                entity.Property(e => e.LibeClub).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureCommune>(entity =>
            {
                entity.HasKey(e => e.CodeComm);

                entity.ToTable("Nomenclature_Commune");

                entity.Property(e => e.CodeComm)
                    .HasMaxLength(50)
                    .HasComment("Commune");
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureConcerne>(entity =>
            {
                entity.HasKey(e => e.CodeConcerne);

                entity.ToTable("Nomenclature_Concerne");

                entity.Property(e => e.CodeConcerne).HasMaxLength(50);
                entity.Property(e => e.LibeConcerne).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureConstatation>(entity =>
            {
                entity.HasKey(e => e.CodeCons);

                entity.ToTable("Nomenclature_Constatation");

                entity.Property(e => e.CodeCons).HasMaxLength(50);
                entity.Property(e => e.LibeCons).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureCorp>(entity =>
            {
                entity.HasKey(e => e.CodeCorp);

                entity.ToTable("Nomenclature_Corps");

                entity.Property(e => e.CodeCorp)
                    .HasMaxLength(50)
                    .HasComment("Code corps");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeCorp)
                    .HasMaxLength(50)
                    .HasComment("Libellé corps(Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<NomenclatureCouverture>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Nomenclature_Couverture");

                entity.Property(e => e.Annescol)
                    .HasMaxLength(50)
                    .HasColumnName("annescol");
                entity.Property(e => e.CodeTranCouv).HasMaxLength(50);
                entity.Property(e => e.Codegouv)
                    .HasMaxLength(50)
                    .HasColumnName("codegouv");
                entity.Property(e => e.Couverture)
                    .HasMaxLength(50)
                    .HasColumnName("couverture");
            });

            modelBuilder.Entity<NomenclatureDecisionReclamation>(entity =>
            {
                entity.HasKey(e => e.CodeReclDeci);

                entity.ToTable("Nomenclature_DecisionReclamation");

                entity.Property(e => e.CodeReclDeci)
                    .HasMaxLength(50)
                    .HasComment("Commune");
                entity.Property(e => e.LibeReclDeci).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureDedreHandicap>(entity =>
            {
                entity.HasKey(e => e.CodeDegrHand);

                entity.ToTable("Nomenclature_DedreHandicap");

                entity.Property(e => e.CodeDegrHand).HasMaxLength(50);
                entity.Property(e => e.LibeDegrHand).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureDelegation>(entity =>
            {
                entity.HasKey(e => e.CodeDele);

                entity.ToTable("Nomenclature_Delegation");

                entity.Property(e => e.CodeDele)
                    .HasMaxLength(50)
                    .HasComment("Code délégation");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.CodeGouv)
                    .HasMaxLength(50)
                    .HasComment("Code gouvernorat");
                entity.Property(e => e.LibeDele)
                    .HasMaxLength(50)
                    .HasComment("Libellé délégation");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");

                entity.HasOne(d => d.CodeGouvNavigation).WithMany(p => p.NomenclatureDelegations)
                    .HasForeignKey(d => d.CodeGouv)
                    .HasConstraintName("FK_Nomenclature_Delegation_Nomenclature_Gouvernorat");
            });

            modelBuilder.Entity<NomenclatureDiplome>(entity =>
            {
                entity.HasKey(e => e.CodeDipl);

                entity.ToTable("Nomenclature_Diplome");

                entity.Property(e => e.CodeDipl)
                    .HasMaxLength(50)
                    .HasComment("Code diplome");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeDipl)
                    .HasMaxLength(500)
                    .HasComment("Libellé diplome (Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<NomenclatureDistrict>(entity =>
            {
                entity.HasKey(e => e.CodeDist);

                entity.ToTable("Nomenclature_District");

                entity.Property(e => e.CodeDist)
                    .HasMaxLength(50)
                    .HasComment("Code district");
                entity.Property(e => e.LibeDist)
                    .HasMaxLength(50)
                    .HasComment("Libellé district");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<NomenclatureElevePresent>(entity =>
            {
                entity.HasKey(e => e.CodeElevePresent);

                entity.ToTable("Nomenclature_ElevePresent");

                entity.Property(e => e.CodeElevePresent).HasMaxLength(50);
                entity.Property(e => e.LibeElevePresent).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureEmplacementEtablissement>(entity =>
            {
                entity.HasKey(e => e.CodeEmpl).HasName("PK_Nomenclature_Emplacement");

                entity.ToTable("Nomenclature_EmplacementEtablissement");

                entity.Property(e => e.CodeEmpl)
                    .HasMaxLength(50)
                    .HasComment("خصائص الفضاء الخارجي");
                entity.Property(e => e.LibeEmpl).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureEmplacementSiege>(entity =>
            {
                entity.HasKey(e => e.CodeEmplSieg);

                entity.ToTable("Nomenclature_EmplacementSiege");

                entity.Property(e => e.CodeEmplSieg).HasMaxLength(50);
                entity.Property(e => e.LibeEmplSieg).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureEquipement>(entity =>
            {
                entity.HasKey(e => e.CodeEqui);

                entity.ToTable("Nomenclature_Equipement");

                entity.Property(e => e.CodeEqui).HasMaxLength(50);
                entity.Property(e => e.CaraEqui).UseCollation("Arabic_CI_AS");
                entity.Property(e => e.CodeTypeEqui).HasMaxLength(50);

                entity.HasOne(d => d.CodeTypeEquiNavigation).WithMany(p => p.NomenclatureEquipements)
                    .HasForeignKey(d => d.CodeTypeEqui)
                    .HasConstraintName("FK_Nomenclature_Equipement_Nomenclature_TypeEquipement");
            });

            modelBuilder.Entity<NomenclatureEtablissement>(entity =>
            {
                entity.HasKey(e => e.CodeEtab).HasName("PK_Nomenclature_Etablissement_1");

                entity.ToTable("Nomenclature_Etablissement");

                entity.HasIndex(e => e.CodeTypeEtab, "NonClusteredIndex-20201201-132620");

                entity.HasIndex(e => e.CodeEtab, "index_Etab_2");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AdreEtab).HasMaxLength(500);
                entity.Property(e => e.AdrePersFond)
                    .HasMaxLength(250)
                    .HasComment("Adresse personnel fondateur");
                entity.Property(e => e.CausFerm).HasMaxLength(500);
                entity.Property(e => e.CodeComm)
                    .HasMaxLength(50)
                    .HasComment("Commune");
                entity.Property(e => e.CodeCommEtab).HasMaxLength(50);
                entity.Property(e => e.CodeDele)
                    .HasMaxLength(50)
                    .HasComment("Délégation");
                entity.Property(e => e.CodeDeleFond)
                    .HasMaxLength(50)
                    .HasComment("Délégation fondateur");
                entity.Property(e => e.CodeDipl)
                    .HasMaxLength(50)
                    .HasComment("Diplome");
                entity.Property(e => e.CodeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGenrFond)
                    .HasMaxLength(50)
                    .HasComment("Genre");
                entity.Property(e => e.CodeMiniFond).HasMaxLength(50);
                entity.Property(e => e.CodeNiveEtud)
                    .HasMaxLength(50)
                    .HasComment("Code Niveau d'Etude");
                entity.Property(e => e.CodePostEtab).HasMaxLength(50);
                entity.Property(e => e.CodePostFond)
                    .HasMaxLength(50)
                    .HasComment("Code postale");
                entity.Property(e => e.CodeSect)
                    .HasMaxLength(50)
                    .HasComment("Secteur");
                entity.Property(e => e.CodeSituFami)
                    .HasMaxLength(50)
                    .HasComment("Code genre");
                entity.Property(e => e.CodeTypeEtab)
                    .HasMaxLength(50)
                    .HasComment("Type établissement");
                entity.Property(e => e.CodeZoneHabi)
                    .HasMaxLength(50)
                    .HasComment("Zone habitation");
                entity.Property(e => e.DateCrea)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date de création")
                    .HasColumnType("datetime");
                entity.Property(e => e.DateCreaBd)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date de création")
                    .HasColumnType("datetime")
                    .HasColumnName("DateCreaBD");
                entity.Property(e => e.DateDeciOuve)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date du décision d'ouverture")
                    .HasColumnType("datetime");
                entity.Property(e => e.DateDeliv)
                    .HasComment("Date de délivrance CIN")
                    .HasColumnType("datetime");
                entity.Property(e => e.DateDemaActi)
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("La date du démarage de l'activité")
                    .HasColumnType("datetime");
                entity.Property(e => e.DateDepoCahiChar)
                    .HasComment("La date dépôt du cahier des charges")
                    .HasColumnType("datetime");
                entity.Property(e => e.DateFerm).HasColumnType("datetime");
                entity.Property(e => e.DateNaisFond)
                    .HasComment("Date de naissance fondateur")
                    .HasColumnType("datetime");
                entity.Property(e => e.DateValFerm)
                    .HasColumnType("datetime")
                    .HasColumnName("DateVAlFerm");
                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .HasComment("E-mail");
                entity.Property(e => e.LibeEtab)
                    .HasMaxLength(250)
                    .HasComment("Libellé établissement");
                entity.Property(e => e.LieuNaisFond)
                    .HasMaxLength(50)
                    .HasComment("Lieu de naissance fondateur");
                entity.Property(e => e.MatrFisc).HasMaxLength(50);
                entity.Property(e => e.NomPrenFond)
                    .HasMaxLength(50)
                    .HasComment("Nom et Prénom du fondateur de projet");
                entity.Property(e => e.NombEnfa).HasComment("Nombre d'enfant");
                entity.Property(e => e.NumeDeciOuve)
                    .HasMaxLength(50)
                    .HasComment("Numéro du décision d'ouverture");
                entity.Property(e => e.NumePiecIden)
                    .HasMaxLength(50)
                    .HasComment("CIN");
                entity.Property(e => e.Prof)
                    .HasMaxLength(250)
                    .HasComment("Profession");
                entity.Property(e => e.Tele)
                    .HasMaxLength(45)
                    .HasComment("Téléphone");
                entity.Property(e => e.UserFerm).HasMaxLength(50);

                entity.HasOne(d => d.CodeCommNavigation).WithMany(p => p.NomenclatureEtablissements)
                    .HasForeignKey(d => d.CodeComm)
                    .HasConstraintName("FK_Nomenclature_Etablissement_Nomenclature_Commune");

                entity.HasOne(d => d.CodeDeleNavigation).WithMany(p => p.NomenclatureEtablissementCodeDeleNavigations)
                    .HasForeignKey(d => d.CodeDele)
                    .HasConstraintName("FK_Nomenclature_Etablissement_Nomenclature_Delegation");

                entity.HasOne(d => d.CodeDeleFondNavigation).WithMany(p => p.NomenclatureEtablissementCodeDeleFondNavigations)
                    .HasForeignKey(d => d.CodeDeleFond)
                    .HasConstraintName("FK_Nomenclature_Etablissement_Nomenclature_Delegation1");

                entity.HasOne(d => d.CodeDiplNavigation).WithMany(p => p.NomenclatureEtablissements)
                    .HasForeignKey(d => d.CodeDipl)
                    .HasConstraintName("FK_Nomenclature_Etablissement_Nomenclature_Diplome");

                entity.HasOne(d => d.CodeNiveEtudNavigation).WithMany(p => p.NomenclatureEtablissements)
                    .HasForeignKey(d => d.CodeNiveEtud)
                    .HasConstraintName("FK_Nomenclature_Etablissement_Nomenclature_NiveauEtude");

                entity.HasOne(d => d.CodeSectNavigation).WithMany(p => p.NomenclatureEtablissements)
                    .HasForeignKey(d => d.CodeSect)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nomenclature_Etablissement_Nomenclature_Secteur");

                entity.HasOne(d => d.CodeSituFamiNavigation).WithMany(p => p.NomenclatureEtablissements)
                    .HasForeignKey(d => d.CodeSituFami)
                    .HasConstraintName("FK_Nomenclature_Etablissement_Nomenclature_SituationFamiliale");

                entity.HasOne(d => d.CodeTypeEtabNavigation).WithMany(p => p.NomenclatureEtablissements)
                    .HasForeignKey(d => d.CodeTypeEtab)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nomenclature_Etablissement_Nomenclature_TypeEtablissement");

                entity.HasOne(d => d.CodeZoneHabiNavigation).WithMany(p => p.NomenclatureEtablissements)
                    .HasForeignKey(d => d.CodeZoneHabi)
                    .HasConstraintName("FK_Nomenclature_Etablissement_Nomenclature_Zone");
            });

            modelBuilder.Entity<NomenclatureEtatEtablissement>(entity =>
            {
                entity.HasKey(e => e.CodeEtatEtab);

                entity.ToTable("Nomenclature_EtatEtablissement");

                entity.Property(e => e.CodeEtatEtab)
                    .HasMaxLength(50)
                    .HasComment("Code type établissement");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.CodeTypeEtatEtab)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");
                entity.Property(e => e.LibeEtatEtab)
                    .HasMaxLength(50)
                    .HasComment("Libellé type établissement (Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");

                entity.HasOne(d => d.CodeTypeEtatEtabNavigation).WithMany(p => p.NomenclatureEtatEtablissements)
                    .HasForeignKey(d => d.CodeTypeEtatEtab)
                    .HasConstraintName("FK__Nomenclat__CodeT__3A8CA01F");
            });

            modelBuilder.Entity<NomenclatureEtatFamille>(entity =>
            {
                entity.HasKey(e => e.CodeEtatFam);

                entity.ToTable("Nomenclature_EtatFamille");

                entity.Property(e => e.CodeEtatFam).HasMaxLength(50);
                entity.Property(e => e.LibeEtatFam).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureEtatParent>(entity =>
            {
                entity.HasKey(e => e.CodeEtatPare);

                entity.ToTable("Nomenclature_EtatParent");

                entity.Property(e => e.CodeEtatPare).HasMaxLength(50);
                entity.Property(e => e.LibeEtatPare).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureEtatPsycologique>(entity =>
            {
                entity.HasKey(e => e.CodeEtatPsyc);

                entity.ToTable("Nomenclature_EtatPsycologique");

                entity.Property(e => e.CodeEtatPsyc).HasMaxLength(50);
                entity.Property(e => e.LibeEtatPsyc).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureEtatReclamation>(entity =>
            {
                entity.HasKey(e => e.CodeEtatRecl);

                entity.ToTable("Nomenclature_EtatReclamation");

                entity.Property(e => e.CodeEtatRecl)
                    .HasMaxLength(50)
                    .HasComment("Commune");
                entity.Property(e => e.LibeEtatRecl).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureEtatSante>(entity =>
            {
                entity.HasKey(e => e.CodeEtatSant);

                entity.ToTable("Nomenclature_EtatSante");

                entity.Property(e => e.CodeEtatSant).HasMaxLength(50);
                entity.Property(e => e.LibeEtatSant).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureEtatSignalisation>(entity =>
            {
                entity.HasKey(e => e.CodeEtatSignalisation);

                entity.ToTable("Nomenclature_EtatSignalisation");

                entity.Property(e => e.CodeEtatSignalisation).HasMaxLength(50);
                entity.Property(e => e.LibeEtatSignalisation).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureFonction>(entity =>
            {
                entity.HasKey(e => e.CodeFonc);

                entity.ToTable("Nomenclature_Fonction");

                entity.Property(e => e.CodeFonc)
                    .HasMaxLength(50)
                    .HasComment("Code Fonction");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeFonc)
                    .HasMaxLength(50)
                    .HasComment("Libellé Fonction (Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<NomenclatureGenerale>(entity =>
            {
                entity.HasKey(e => e.Pays);

                entity.ToTable("Nomenclature_Generale");

                entity.Property(e => e.Pays).HasMaxLength(255);
                entity.Property(e => e.DelaiInspection).HasMaxLength(50);
                entity.Property(e => e.Direction)
                    .HasMaxLength(255)
                    .HasColumnName("direction");
                entity.Property(e => e.Ministere)
                    .HasMaxLength(255)
                    .HasColumnName("ministere");
                entity.Property(e => e.NbjourSup).HasColumnName("nbjourSup");
                entity.Property(e => e.NbjourSupSignalisation).HasColumnName("nbjourSupSignalisation");
                entity.Property(e => e.NbjoursupRapport).HasColumnName("nbjoursupRapport");
                entity.Property(e => e.Nbjourupdate).HasColumnName("nbjourupdate");
                entity.Property(e => e.NbjourupdateEnfant).HasColumnName("nbjourupdateEnfant");
                entity.Property(e => e.NbjourupdateRapport).HasColumnName("nbjourupdateRapport");
                entity.Property(e => e.NbjourupdateSignalisation).HasColumnName("nbjourupdateSignalisation");
                entity.Property(e => e.Region)
                    .HasMaxLength(255)
                    .HasColumnName("region");
                entity.Property(e => e.Signature)
                    .HasMaxLength(255)
                    .HasColumnName("signature");
            });

            modelBuilder.Entity<NomenclatureGenre>(entity =>
            {
                entity.HasKey(e => e.CodeGenr);

                entity.ToTable("Nomenclature_Genre");

                entity.Property(e => e.CodeGenr)
                    .HasMaxLength(50)
                    .HasComment("Code genre");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeGenr)
                    .HasMaxLength(50)
                    .HasComment("Libellé genre (Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<NomenclatureGouvernorat>(entity =>
            {
                entity.HasKey(e => e.CodeGouv);

                entity.ToTable("Nomenclature_Gouvernorat");

                entity.Property(e => e.CodeGouv)
                    .HasMaxLength(50)
                    .HasComment("Code gouvernorat");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.CodeDist)
                    .HasMaxLength(50)
                    .HasComment("District");
                entity.Property(e => e.LibeGouv)
                    .HasMaxLength(50)
                    .HasComment("Libellé gouvernorat");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");

                entity.HasOne(d => d.CodeDistNavigation).WithMany(p => p.NomenclatureGouvernorats)
                    .HasForeignKey(d => d.CodeDist)
                    .HasConstraintName("FK_Nomenclature_Gouvernorat_Nomenclature_District");
            });

            modelBuilder.Entity<NomenclatureGrade>(entity =>
            {
                entity.HasKey(e => e.CodeGrad);

                entity.ToTable("Nomenclature_Grade");

                entity.Property(e => e.CodeGrad).HasMaxLength(50);
                entity.Property(e => e.LibeGrad).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureInformateur>(entity =>
            {
                entity.HasKey(e => e.CodeInformateur);

                entity.ToTable("Nomenclature_Informateur");

                entity.Property(e => e.CodeInformateur).HasMaxLength(50);
                entity.Property(e => e.LibeInformateur).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureInfrastrcture>(entity =>
            {
                entity.HasKey(e => e.CodeInfrastrcture);

                entity.ToTable("Nomenclature_Infrastrcture");

                entity.Property(e => e.CodeInfrastrcture).HasMaxLength(50);
                entity.Property(e => e.LibeInfrastrcture).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureIntergrationHandicap>(entity =>
            {
                entity.HasKey(e => e.CodeInteHand);

                entity.ToTable("Nomenclature_IntergrationHandicap");

                entity.Property(e => e.CodeInteHand).HasMaxLength(50);
                entity.Property(e => e.LibeInteHand).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureInterventionnecessaire>(entity =>
            {
                entity.HasKey(e => e.CodeInterv);

                entity.ToTable("Nomenclature_Interventionnecessaire");

                entity.Property(e => e.CodeInterv).HasMaxLength(50);
                entity.Property(e => e.CodeTypeInterv).HasMaxLength(50);
                entity.Property(e => e.LibeInterv).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureLangueMaternelle>(entity =>
            {
                entity.HasKey(e => e.CodeLangMate);

                entity.ToTable("Nomenclature_LangueMaternelle");

                entity.Property(e => e.CodeLangMate)
                    .HasMaxLength(50)
                    .HasComment("Code Niveau d'Etude");
                entity.Property(e => e.Acti)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeLangMate)
                    .HasMaxLength(50)
                    .HasComment("Libellé Niveau d'Etude (Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<NomenclatureLienExterne>(entity =>
            {
                entity.HasKey(e => e.CodeLienExterne);

                entity.ToTable("Nomenclature_LienExterne");

                entity.Property(e => e.CodeLienExterne).HasMaxLength(50);
                entity.Property(e => e.LibeLienExterne).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureMethodeSignalisation>(entity =>
            {
                entity.HasKey(e => e.CodeMethodeSignalisation);

                entity.ToTable("Nomenclature_MethodeSignalisation");

                entity.Property(e => e.CodeMethodeSignalisation).HasMaxLength(50);
                entity.Property(e => e.LibeMethodeSignalisation).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureMinistereFondatrice>(entity =>
            {
                entity.HasKey(e => e.CodeMiniFond);

                entity.ToTable("Nomenclature_MinistereFondatrice");

                entity.Property(e => e.CodeMiniFond).HasMaxLength(50);
                entity.Property(e => e.Acti).HasDefaultValueSql("((1))");
                entity.Property(e => e.LibeMiniFond).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureNationalite>(entity =>
            {
                entity.HasKey(e => e.CodeNati);

                entity.ToTable("Nomenclature_Nationalite");

                entity.Property(e => e.CodeNati).HasMaxLength(50);
                entity.Property(e => e.LibeNati).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureNatureActivite>(entity =>
            {
                entity.HasKey(e => e.CodeNatAct);

                entity.ToTable("Nomenclature_NatureActivite");

                entity.Property(e => e.CodeNatAct).HasMaxLength(50);
                entity.Property(e => e.LibeNatAct).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureNatureAnomalie>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Nomenclature_NatureAnomalie");

                entity.Property(e => e.CodeNatureAnomalie).HasMaxLength(50);
                entity.Property(e => e.LibeNatureAnomalie).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureNatureInvest>(entity =>
            {
                entity.HasKey(e => e.CodeNatInv);

                entity.ToTable("Nomenclature_NatureInvest");

                entity.Property(e => e.CodeNatInv).HasMaxLength(50);
                entity.Property(e => e.LibeNatInv).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureNaturePere>(entity =>
            {
                entity.HasKey(e => e.CodeNaturePere);

                entity.ToTable("Nomenclature_NaturePere");

                entity.Property(e => e.CodeNaturePere).HasMaxLength(50);
                entity.Property(e => e.LibeNaturePere).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureNatureProposition>(entity =>
            {
                entity.HasKey(e => e.CodeNatPro);

                entity.ToTable("Nomenclature_NatureProposition");

                entity.Property(e => e.CodeNatPro).HasMaxLength(50);
                entity.Property(e => e.LibeNatPro).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureNatureSignalisation>(entity =>
            {
                entity.HasKey(e => e.CodeNatureSignalisation);

                entity.ToTable("Nomenclature_NatureSignalisation");

                entity.Property(e => e.CodeNatureSignalisation).HasMaxLength(50);
                entity.Property(e => e.LibeNatureSignalisation).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureNatureformateur>(entity =>
            {
                entity.HasKey(e => e.CodeNatFor);

                entity.ToTable("Nomenclature_Natureformateur");

                entity.Property(e => e.CodeNatFor).HasMaxLength(50);
                entity.Property(e => e.LibeNatFor).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureNatureformation>(entity =>
            {
                entity.HasKey(e => e.CodeNatFor);

                entity.ToTable("Nomenclature_Natureformation");

                entity.Property(e => e.CodeNatFor).HasMaxLength(50);
                entity.Property(e => e.LibeNatFor).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureNiveauEleve>(entity =>
            {
                entity.HasKey(e => e.CodeNivEle);

                entity.ToTable("Nomenclature_NiveauEleve");

                entity.Property(e => e.CodeNivEle).HasMaxLength(50);
                entity.Property(e => e.LibeNivEle).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureNiveauEtude>(entity =>
            {
                entity.HasKey(e => e.CodeNiveEtud);

                entity.ToTable("Nomenclature_NiveauEtude");

                entity.Property(e => e.CodeNiveEtud)
                    .HasMaxLength(50)
                    .HasComment("Code Niveau d'Etude");
                entity.Property(e => e.Acti)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeNiveEtud)
                    .HasMaxLength(50)
                    .HasComment("Libellé Niveau d'Etude (Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<NomenclatureNiveauFormation>(entity =>
            {
                entity.HasKey(e => e.CodeNivFor);

                entity.ToTable("Nomenclature_NiveauFormation");

                entity.Property(e => e.CodeNivFor).HasMaxLength(50);
                entity.Property(e => e.LibeNivFor).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureNiveauSalaire>(entity =>
            {
                entity.HasKey(e => e.CodeNiveSala);

                entity.ToTable("Nomenclature_NiveauSalaire");

                entity.Property(e => e.CodeNiveSala)
                    .HasMaxLength(50)
                    .HasComment("Code Niveau d'Etude");
                entity.Property(e => e.Acti)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeNiveSala)
                    .HasMaxLength(50)
                    .HasComment("Libellé Niveau d'Etude (Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<NomenclatureOrganisationAdministrative>(entity =>
            {
                entity.HasKey(e => e.CodeOrgaAdmi);

                entity.ToTable("Nomenclature_OrganisationAdministrative");

                entity.Property(e => e.CodeOrgaAdmi)
                    .HasMaxLength(50)
                    .HasComment("Commune");
                entity.Property(e => e.CodeTypeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code type établissement");
                entity.Property(e => e.LibeOrgaAdmi).HasMaxLength(250);

                entity.HasOne(d => d.CodeTypeEtabNavigation).WithMany(p => p.NomenclatureOrganisationAdministratives)
                    .HasForeignKey(d => d.CodeTypeEtab)
                    .HasConstraintName("FK_Nomenclature_OrganisationAdministrative_Nomenclature_TypeEtablissement");
            });

            modelBuilder.Entity<NomenclatureOrganisationPedagogique>(entity =>
            {
                entity.HasKey(e => e.CodeOrgaPeda);

                entity.ToTable("Nomenclature_OrganisationPedagogique");

                entity.Property(e => e.CodeOrgaPeda)
                    .HasMaxLength(50)
                    .HasComment("Commune");
                entity.Property(e => e.CodeTypeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code type établissement");
                entity.Property(e => e.LibeOrgaPeda).HasMaxLength(250);

                entity.HasOne(d => d.CodeTypeEtabNavigation).WithMany(p => p.NomenclatureOrganisationPedagogiques)
                    .HasForeignKey(d => d.CodeTypeEtab)
                    .HasConstraintName("FK_Nomenclature_OrganisationPedagogique_Nomenclature_TypeEtablissement");
            });

            modelBuilder.Entity<NomenclatureOuvertureEtablissement>(entity =>
            {
                entity.HasKey(e => e.CodeOuveEtab);

                entity.ToTable("Nomenclature_OuvertureEtablissement");

                entity.Property(e => e.CodeOuveEtab).HasMaxLength(50);
                entity.Property(e => e.LibeOuveEtab).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclaturePriorite>(entity =>
            {
                entity.HasKey(e => e.CodePrio);

                entity.ToTable("Nomenclature_Priorite");

                entity.Property(e => e.CodePrio)
                    .HasMaxLength(50)
                    .HasComment("Commune");
                entity.Property(e => e.LibePrio).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureProfession>(entity =>
            {
                entity.HasKey(e => e.CodeProf);

                entity.ToTable("Nomenclature_Profession");

                entity.Property(e => e.CodeProf)
                    .HasMaxLength(50)
                    .HasComment("Code Type Equipement");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeProf)
                    .HasMaxLength(250)
                    .HasComment("Libellée Type Equipement");
                entity.Property(e => e.OrdrAffi).HasComment("Ordre d'affichage");
            });

            modelBuilder.Entity<NomenclatureQualite>(entity =>
            {
                entity.HasKey(e => e.CodeQual);

                entity.ToTable("Nomenclature_Qualite");

                entity.Property(e => e.CodeQual)
                    .HasMaxLength(50)
                    .HasComment("Code qualite");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeQual)
                    .HasMaxLength(50)
                    .HasComment("Libellé qualite (Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<NomenclatureRectification>(entity =>
            {
                entity.HasKey(e => e.CodeRect);

                entity.ToTable("Nomenclature_rectification");

                entity.Property(e => e.CodeRect).HasMaxLength(50);
                entity.Property(e => e.LibeRect).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureRegimePropriete>(entity =>
            {
                entity.HasKey(e => e.CodeRegiProp);

                entity.ToTable("Nomenclature_RegimePropriete");

                entity.Property(e => e.CodeRegiProp).HasMaxLength(50);
                entity.Property(e => e.LibeRegiProp).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureRevenuMensuel>(entity =>
            {
                entity.HasKey(e => e.CodeReveMens);

                entity.ToTable("Nomenclature_RevenuMensuel");

                entity.Property(e => e.CodeReveMens)
                    .HasMaxLength(50)
                    .HasComment("Code genre");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeReveMens)
                    .HasMaxLength(50)
                    .HasComment("Libellé genre (Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<NomenclatureRubriqueInspection>(entity =>
            {
                entity.HasKey(e => e.CodeRubrInsp).HasName("PK_Nomenclature_RubriqueInspection1");

                entity.ToTable("Nomenclature_RubriqueInspection");

                entity.Property(e => e.CodeRubrInsp).HasMaxLength(50);
                entity.Property(e => e.CodeCateRubrInsp).HasMaxLength(50);
                entity.Property(e => e.LibeRubrInsp).HasMaxLength(250);

                entity.HasOne(d => d.CodeCateRubrInspNavigation).WithMany(p => p.NomenclatureRubriqueInspections)
                    .HasForeignKey(d => d.CodeCateRubrInsp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nomenclature_RubriqueInspection_Nomenclature_CategorieRubriqueInspection");

                entity.HasMany(d => d.CodeCons).WithMany(p => p.CodeRubrInsps)
                    .UsingEntity<Dictionary<string, object>>(
                        "NomenclatureConstatationRubriqueInspection",
                        r => r.HasOne<NomenclatureConstatation>().WithMany()
                            .HasForeignKey("CodeCons")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_Nomenclature_ConstatationRubriqueInspection_Nomenclature_Constatation"),
                        l => l.HasOne<NomenclatureRubriqueInspection>().WithMany()
                            .HasForeignKey("CodeRubrInsp")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_Nomenclature_ConstatationRubriqueInspection_Nomenclature_RubriqueInspection"),
                        j =>
                        {
                            j.HasKey("CodeRubrInsp", "CodeCons");
                            j.ToTable("Nomenclature_ConstatationRubriqueInspection");
                            j.IndexerProperty<string>("CodeRubrInsp").HasMaxLength(50);
                            j.IndexerProperty<string>("CodeCons").HasMaxLength(50);
                        });
            });

            modelBuilder.Entity<NomenclatureSecteur>(entity =>
            {
                entity.HasKey(e => e.CodeSect);

                entity.ToTable("Nomenclature_Secteur");

                entity.Property(e => e.CodeSect)
                    .HasMaxLength(50)
                    .HasComment("Code secteur");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeSect)
                    .HasMaxLength(50)
                    .HasComment("Libellé secteur (Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<NomenclatureSecteurFormation>(entity =>
            {
                entity.HasKey(e => e.CodeSecFor);

                entity.ToTable("Nomenclature_SecteurFormation");

                entity.Property(e => e.CodeSecFor).HasMaxLength(50);
                entity.Property(e => e.LibeSecFor).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureSignalisation>(entity =>
            {
                entity.HasKey(e => e.CodeSignalisation);

                entity.ToTable("Nomenclature_Signalisation");

                entity.Property(e => e.Acti).HasColumnName("acti");
                entity.Property(e => e.ChefService).HasMaxLength(50);
                entity.Property(e => e.CodeConcerne).HasMaxLength(50);
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeInformateur).HasMaxLength(50);
                entity.Property(e => e.CodeInspecteur).HasMaxLength(50);
                entity.Property(e => e.CodeResponsable).HasMaxLength(50);
                entity.Property(e => e.CodeStatus).HasMaxLength(50);
                entity.Property(e => e.CodeTypeSignalisation).HasMaxLength(50);
                entity.Property(e => e.ConusltatEnfance)
                    .HasDefaultValueSql("((0))")
                    .HasColumnName("conusltatEnfance");
                entity.Property(e => e.DateAnalyse).HasColumnType("date");
                entity.Property(e => e.DateChefService).HasColumnType("date");
                entity.Property(e => e.DateCloture).HasColumnType("date");
                entity.Property(e => e.DateCreation).HasColumnType("date");
                entity.Property(e => e.DateDepot).HasColumnType("date");
                entity.Property(e => e.DateInfoInspecteur).HasColumnType("date");
                entity.Property(e => e.DateSignalisation).HasColumnType("date");
                entity.Property(e => e.Datecreationrapport)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreationrapport");
                entity.Property(e => e.Datevisite)
                    .HasColumnType("date")
                    .HasColumnName("datevisite");
                entity.Property(e => e.Fichier).HasColumnName("fichier");
                entity.Property(e => e.Inspecteur2).HasMaxLength(50);
                entity.Property(e => e.MethodeSignalisation).HasMaxLength(50);
                entity.Property(e => e.MotifSupression).HasMaxLength(255);
                entity.Property(e => e.NomInformateur).HasMaxLength(50);
                entity.Property(e => e.NumeroDepot).HasMaxLength(50);
                entity.Property(e => e.Tel).HasMaxLength(50);
                entity.Property(e => e.TypeEtablissement).HasMaxLength(50);
                entity.Property(e => e.TypeSignalisation).HasMaxLength(50);

                entity.HasOne(d => d.CodeConcerneNavigation).WithMany(p => p.NomenclatureSignalisations)
                    .HasForeignKey(d => d.CodeConcerne)
                    .HasConstraintName("FK_Nomenclature_Signalisation_Nomenclature_Concerne");

                entity.HasOne(d => d.CodeDeleNavigation).WithMany(p => p.NomenclatureSignalisations)
                    .HasForeignKey(d => d.CodeDele)
                    .HasConstraintName("FK_Nomenclature_Signalisation_Nomenclature_Delegation");

                entity.HasOne(d => d.CodeGouvNavigation).WithMany(p => p.NomenclatureSignalisations)
                    .HasForeignKey(d => d.CodeGouv)
                    .HasConstraintName("FK_Nomenclature_Signalisation_Nomenclature_Gouve");

                entity.HasOne(d => d.CodeInformateurNavigation).WithMany(p => p.NomenclatureSignalisations)
                    .HasForeignKey(d => d.CodeInformateur)
                    .HasConstraintName("FK_Nomenclature_Signalisation_Nomenclature_Informateur");

                entity.HasOne(d => d.CodeTypeSignalisationNavigation).WithMany(p => p.NomenclatureSignalisations)
                    .HasForeignKey(d => d.CodeTypeSignalisation)
                    .HasConstraintName("FK_Nomenclature_Signalisation_Nomenclature_TypeSignalisation");
            });

            modelBuilder.Entity<NomenclatureSituationFamiliale>(entity =>
            {
                entity.HasKey(e => e.CodeSituFami);

                entity.ToTable("Nomenclature_SituationFamiliale");

                entity.Property(e => e.CodeSituFami)
                    .HasMaxLength(50)
                    .HasComment("Code genre");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeSituFami)
                    .HasMaxLength(50)
                    .HasComment("Libellé genre (Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<NomenclatureSituationProfessionel>(entity =>
            {
                entity.HasKey(e => e.CodeSituProf);

                entity.ToTable("Nomenclature_SituationProfessionel");

                entity.Property(e => e.CodeSituProf).HasMaxLength(50);
                entity.Property(e => e.LibeSituProf).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureStatutSignalisation>(entity =>
            {
                entity.HasKey(e => e.CodeStatutSignalisation);

                entity.ToTable("Nomenclature_StatutSignalisation");

                entity.Property(e => e.CodeStatutSignalisation).HasMaxLength(50);
                entity.Property(e => e.CodeEtatSignalisation).HasMaxLength(50);
                entity.Property(e => e.LibeStatutSignalisation).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureStructureAttache>(entity =>
            {
                entity.HasKey(e => e.CodeStruAtta);

                entity.ToTable("Nomenclature_StructureAttache");

                entity.Property(e => e.CodeStruAtta).HasMaxLength(50);
                entity.Property(e => e.LibeStruAtta).HasMaxLength(1000);
            });

            modelBuilder.Entity<NomenclatureTerrain>(entity =>
            {
                entity.HasKey(e => e.CodeTerrain);

                entity.ToTable("Nomenclature_Terrain");

                entity.Property(e => e.CodeTerrain).HasMaxLength(50);
                entity.Property(e => e.LibeTerrain).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureTrancheAge>(entity =>
            {
                entity.HasKey(e => e.CodeTranAge);

                entity.ToTable("Nomenclature_TrancheAge");

                entity.Property(e => e.CodeTranAge).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTranAge).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureTrangeAgeCouv>(entity =>
            {
                entity.HasKey(e => e.CodeTranCouv);

                entity.ToTable("Nomenclature_TrangeAgeCouv");

                entity.Property(e => e.CodeTranCouv).HasMaxLength(50);
                entity.Property(e => e.LibeTranCouv).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureTypeAffiche>(entity =>
            {
                entity.HasKey(e => e.CodeTypeAffiche);

                entity.ToTable("Nomenclature_TypeAffiche");

                entity.Property(e => e.CodeTypeAffiche).HasMaxLength(50);
                entity.Property(e => e.LibeTypeAffiche).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureTypeBoolean>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Nomenclature_TypeBoolean");

                entity.Property(e => e.Libe).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureTypeCloture>(entity =>
            {
                entity.HasKey(e => e.CodeTypeClot);

                entity.ToTable("Nomenclature_TypeCloture");

                entity.Property(e => e.CodeTypeClot)
                    .HasMaxLength(50)
                    .HasComment("خصائص الفضاء الخارجي");
                entity.Property(e => e.LibeTypeClot).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureTypeConnexionInternet>(entity =>
            {
                entity.HasKey(e => e.CodeTypeConnInte);

                entity.ToTable("Nomenclature_TypeConnexionInternet");

                entity.Property(e => e.CodeTypeConnInte)
                    .HasMaxLength(50)
                    .HasComment("خصائص الفضاء الخارجي");
                entity.Property(e => e.LibeTypeConnInte).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureTypeEquipement>(entity =>
            {
                entity.HasKey(e => e.CodeTypeEqui);

                entity.ToTable("Nomenclature_TypeEquipement");

                entity.Property(e => e.CodeTypeEqui).HasMaxLength(50);
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeTypeEqui).HasMaxLength(1000);
                entity.Property(e => e.OrdrAffi).HasComment("Ordre d'affichage");
            });

            modelBuilder.Entity<NomenclatureTypeEspace>(entity =>
            {
                entity.HasKey(e => e.CodeTypeEspa);

                entity.ToTable("Nomenclature_TypeEspace");

                entity.Property(e => e.CodeTypeEspa)
                    .HasMaxLength(50)
                    .HasComment("Code Type Equipement");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.CaraEspa).HasMaxLength(1000);
                entity.Property(e => e.LibeTypeEspa)
                    .HasMaxLength(250)
                    .HasComment("Libellée Type Equipement");
                entity.Property(e => e.OrdrAffi).HasComment("Ordre d'affichage");
            });

            modelBuilder.Entity<NomenclatureTypeEtablissement>(entity =>
            {
                entity.HasKey(e => e.CodeTypeEtab);

                entity.ToTable("Nomenclature_TypeEtablissement");

                entity.Property(e => e.CodeTypeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code type établissement");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.CodeFormulaire).HasMaxLength(50);
                entity.Property(e => e.Formulaire)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.LibeTypeEtab)
                    .HasMaxLength(50)
                    .HasComment("Libellé type établissement (Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<NomenclatureTypeEtatEtablissement>(entity =>
            {
                entity.HasKey(e => e.CodeTypeEtatEtab);

                entity.ToTable("Nomenclature_TypeEtatEtablissement");

                entity.Property(e => e.CodeTypeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureTypeFormation>(entity =>
            {
                entity.HasKey(e => e.CodeTypeForm);

                entity.ToTable("Nomenclature_TypeFormation");

                entity.Property(e => e.CodeTypeForm).HasMaxLength(50);
                entity.Property(e => e.LibeTypeForm).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureTypeFormulaire>(entity =>
            {
                entity.HasKey(e => e.CodeFormulaire);

                entity.ToTable("Nomenclature_TypeFormulaire");

                entity.Property(e => e.CodeFormulaire).HasMaxLength(50);
                entity.Property(e => e.LibeFormulaire).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureTypeHandicap>(entity =>
            {
                entity.HasKey(e => e.CodeTypeHand);

                entity.ToTable("Nomenclature_TypeHandicap");

                entity.Property(e => e.CodeTypeHand).HasMaxLength(50);
                entity.Property(e => e.LibeTypeHand).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureTypeInscription>(entity =>
            {
                entity.HasKey(e => e.CodeTypeInsc);

                entity.ToTable("Nomenclature_TypeInscription");

                entity.Property(e => e.CodeTypeInsc)
                    .HasMaxLength(50)
                    .HasComment("Code Type Equipement");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeTypeInsc)
                    .HasMaxLength(1000)
                    .HasComment("Libellée Type Equipement");
                entity.Property(e => e.OrdrAffi).HasComment("Ordre d'affichage");
            });

            modelBuilder.Entity<NomenclatureTypeInspection>(entity =>
            {
                entity.HasKey(e => e.CodeTypeInsp);

                entity.ToTable("Nomenclature_TypeInspection");

                entity.Property(e => e.CodeTypeInsp).HasMaxLength(50);
                entity.Property(e => e.LibeTypeInsp).HasMaxLength(250);

                entity.HasMany(d => d.CodeCateRubrInsps).WithMany(p => p.CodeTypeInsps)
                    .UsingEntity<Dictionary<string, object>>(
                        "NomenclatureCategorieRubriqueTypeInspection",
                        r => r.HasOne<NomenclatureCategorieRubriqueInspection>().WithMany()
                            .HasForeignKey("CodeCateRubrInsp")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_Nomenclature_CategorieRubriqueTypeInspection_Nomenclature_CategorieRubriqueInspection"),
                        l => l.HasOne<NomenclatureTypeInspection>().WithMany()
                            .HasForeignKey("CodeTypeInsp")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_Nomenclature_CategorieRubriqueTypeInspection_Nomenclature_TypeInspection"),
                        j =>
                        {
                            j.HasKey("CodeTypeInsp", "CodeCateRubrInsp");
                            j.ToTable("Nomenclature_CategorieRubriqueTypeInspection");
                            j.IndexerProperty<string>("CodeTypeInsp").HasMaxLength(50);
                            j.IndexerProperty<string>("CodeCateRubrInsp").HasMaxLength(50);
                        });
            });

            modelBuilder.Entity<NomenclatureTypeIntervention>(entity =>
            {
                entity.HasKey(e => e.CodeTypeInterv);

                entity.ToTable("Nomenclature_TypeIntervention");

                entity.Property(e => e.CodeTypeInterv).HasMaxLength(50);
                entity.Property(e => e.LibeTypeInterv).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureTypeMessage>(entity =>
            {
                entity.HasKey(e => e.CodeTypeM);

                entity.ToTable("Nomenclature_TypeMessage");

                entity.Property(e => e.CodeTypeM).HasMaxLength(50);
                entity.Property(e => e.LibeTypeM).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureTypePriseEnCharge>(entity =>
            {
                entity.HasKey(e => e.CodeTypePrisChar);

                entity.ToTable("Nomenclature_TypePriseEnCharge");

                entity.Property(e => e.CodeTypePrisChar)
                    .HasMaxLength(50)
                    .HasComment("Code Niveau d'Etude");
                entity.Property(e => e.Acti)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeTypePrisChar)
                    .HasMaxLength(50)
                    .HasComment("Libellé Niveau d'Etude (Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<NomenclatureTypePropriete>(entity =>
            {
                entity.HasKey(e => e.CodeTypeProp);

                entity.ToTable("Nomenclature_TypePropriete");

                entity.Property(e => e.CodeTypeProp).HasMaxLength(50);
                entity.Property(e => e.LibeTypeProp).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureTypeRepartition>(entity =>
            {
                entity.HasKey(e => e.CodeTypeRepar);

                entity.ToTable("Nomenclature_TypeRepartition");

                entity.Property(e => e.CodeTypeRepar).HasMaxLength(50);
                entity.Property(e => e.LibeTypeRepar).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureTypeSignalisation>(entity =>
            {
                entity.HasKey(e => e.CodeTypeSignalisation).HasName("PK_Nomenclature_TypeS");

                entity.ToTable("Nomenclature_TypeSignalisation");

                entity.Property(e => e.CodeTypeSignalisation).HasMaxLength(50);
                entity.Property(e => e.LibeTypeSignalisation).HasMaxLength(50);
            });

            modelBuilder.Entity<NomenclatureTypeproposition>(entity =>
            {
                entity.HasKey(e => e.CodetypePro);

                entity.ToTable("Nomenclature_Typeproposition");

                entity.Property(e => e.CodetypePro).HasMaxLength(50);
                entity.Property(e => e.LibetypePro).HasMaxLength(250);
            });

            modelBuilder.Entity<NomenclatureZone>(entity =>
            {
                entity.HasKey(e => e.CodeZone);

                entity.ToTable("Nomenclature_Zone");

                entity.Property(e => e.CodeZone)
                    .HasMaxLength(50)
                    .HasComment("Code zone (Urbain/rurale)");
                entity.Property(e => e.Acti).HasComment("Actif (Oui/Non)");
                entity.Property(e => e.LibeZone)
                    .HasMaxLength(50)
                    .HasComment("Libellé zone (Arabe)");
                entity.Property(e => e.OrdrAffi).HasComment("Order d'affichage");
            });

            modelBuilder.Entity<ParametrageAnneeScolaire>(entity =>
            {
                entity.HasKey(e => e.AnneScol);

                entity.ToTable("Parametrage_AnneeScolaire");

                entity.Property(e => e.AnneScol).ValueGeneratedNever();
                entity.Property(e => e.Acti).HasDefaultValueSql("((1))");
                entity.Property(e => e.CodeUtil).HasMaxLength(50);
                entity.Property(e => e.DateInit).HasColumnType("datetime");
                entity.Property(e => e.Obse).HasMaxLength(500);
            });

            modelBuilder.Entity<ParametrageColumn>(entity =>
            {
                entity.HasKey(e => new { e.NumeNome, e.NumeColu }).HasName("PK_Parametrage_FkColumns");

                entity.ToTable("Parametrage_Columns");

                entity.Property(e => e.CodeEnti).HasMaxLength(50);
                entity.Property(e => e.ColuName).HasMaxLength(50);
                entity.Property(e => e.LibeColu).HasMaxLength(50);
                entity.Property(e => e.LibeNome).HasMaxLength(250);
                entity.Property(e => e.NomTable).HasMaxLength(250);
                entity.Property(e => e.TypeRela).HasMaxLength(50);

                entity.HasOne(d => d.NumeNomeNavigation).WithMany(p => p.ParametrageColumns)
                    .HasForeignKey(d => d.NumeNome)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Parametrage_FkColumns_Parametrage_Nomenclature");
            });

            modelBuilder.Entity<ParametrageColumnRechercheMultiCritere>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdCube });

                entity.ToTable("Parametrage_ColumnRechercheMultiCritere");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.IdCube).HasColumnName("id_Cube");
                entity.Property(e => e.Area)
                    .HasMaxLength(1)
                    .IsFixedLength();
                entity.Property(e => e.Caption).HasMaxLength(250);
                entity.Property(e => e.CellFormatString).HasMaxLength(50);
                entity.Property(e => e.CellFormatType).HasMaxLength(50);
                entity.Property(e => e.Name).HasMaxLength(50);
                entity.Property(e => e.SummaryType).HasMaxLength(50);
            });

            modelBuilder.Entity<ParametrageCubeAnalyse>(entity =>
            {
                entity.ToTable("Parametrage_CubeAnalyse");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.NomCube).HasMaxLength(250);
            });

            modelBuilder.Entity<ParametrageDimensionCube>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdCube });

                entity.ToTable("Parametrage_DimensionCube");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.IdCube).HasColumnName("id_Cube");
                entity.Property(e => e.Area)
                    .HasMaxLength(1)
                    .IsFixedLength();
                entity.Property(e => e.Caption).HasMaxLength(250);
                entity.Property(e => e.CellFormatString).HasMaxLength(50);
                entity.Property(e => e.CellFormatType).HasMaxLength(50);
                entity.Property(e => e.Name).HasMaxLength(50);
                entity.Property(e => e.SummaryType).HasMaxLength(50);
            });

            modelBuilder.Entity<ParametrageGroupeNomenclature>(entity =>
            {
                entity.HasKey(e => e.CodeGrou);

                entity.ToTable("Parametrage_GroupeNomenclature");

                entity.Property(e => e.CodeGrou).HasMaxLength(50);
                entity.Property(e => e.LibeGrou).HasMaxLength(250);
            });

            modelBuilder.Entity<ParametrageNomencaltureActivite>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Parametrage_NomencaltureActivite");

                entity.Property(e => e.CodeActivite).HasMaxLength(50);
                entity.Property(e => e.CodeNoma).HasMaxLength(50);
                entity.Property(e => e.Codeenti).HasColumnName("codeenti");
            });

            modelBuilder.Entity<ParametrageNomencaltureTypeEtab>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Parametrage_NomencaltureTypeEtab");

                entity.Property(e => e.CodeNoma).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.Codeenti).HasColumnName("codeenti");
            });

            modelBuilder.Entity<ParametrageNomenclature>(entity =>
            {
                entity.HasKey(e => e.NumeNome);

                entity.ToTable("Parametrage_Nomenclature");

                entity.Property(e => e.NumeNome).ValueGeneratedNever();
                entity.Property(e => e.Acti).HasDefaultValueSql("((1))");
                entity.Property(e => e.CodeEnti).HasMaxLength(50);
                entity.Property(e => e.CodeGrou).HasMaxLength(50);
                entity.Property(e => e.LibeNome).HasMaxLength(250);
                entity.Property(e => e.NomTable).HasMaxLength(250);
                entity.Property(e => e.SpDelete).HasMaxLength(50);
            });

            modelBuilder.Entity<ParametrageRechercheMultiCritere>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_Parametrage_RechercheMultiCritere_1");

                entity.ToTable("Parametrage_RechercheMultiCritere");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<PassationFiche>(entity =>
            {
                entity.HasKey(e => e.CodePas);

                entity.ToTable("Passation_fiche");

                entity.Property(e => e.CodePas)
                    .ValueGeneratedNever()
                    .HasColumnName("codePas");
                entity.Property(e => e.Adirecteur).HasColumnName("ADirecteur");
                entity.Property(e => e.Codegouv).HasMaxLength(50);
                entity.Property(e => e.Codeutil).HasMaxLength(50);
                entity.Property(e => e.CodeutilM).HasMaxLength(50);
                entity.Property(e => e.Codeutilrapport)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilrapport");
                entity.Property(e => e.DatePas).HasColumnType("date");
                entity.Property(e => e.Datecreation).HasColumnType("datetime");
                entity.Property(e => e.Datemodification).HasColumnType("datetime");
                entity.Property(e => e.Daterapport)
                    .HasColumnType("datetime")
                    .HasColumnName("daterapport");
                entity.Property(e => e.Refrence).HasColumnName("refrence");
            });

            modelBuilder.Entity<PassationParaticipant>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Passation_paraticipant");

                entity.Property(e => e.CodePas).HasColumnName("codePas");
                entity.Property(e => e.CodeUtil).HasMaxLength(50);
            });

            modelBuilder.Entity<PersonnelFiche>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Personnel_Fiche");

                entity.Property(e => e.AdatenotePead).HasMaxLength(50);
                entity.Property(e => e.AdrePers).HasMaxLength(250);
                entity.Property(e => e.AnotePead).HasMaxLength(50);
                entity.Property(e => e.CodeCorp).HasMaxLength(50);
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeDipl).HasMaxLength(50);
                entity.Property(e => e.CodeGenr).HasMaxLength(50);
                entity.Property(e => e.CodeGrad).HasMaxLength(50);
                entity.Property(e => e.CodeNiveEtud).HasMaxLength(50);
                entity.Property(e => e.CodePost).HasMaxLength(50);
                entity.Property(e => e.CodeQual).HasMaxLength(50);
                entity.Property(e => e.CodeReveMens).HasMaxLength(50);
                entity.Property(e => e.CodeSituFami).HasMaxLength(50);
                entity.Property(e => e.Codeutiladd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("codeutiladd");
                entity.Property(e => e.DateCin)
                    .HasColumnType("datetime")
                    .HasColumnName("DateCIN");
                entity.Property(e => e.DateNais).HasColumnType("datetime");
                entity.Property(e => e.Dateaffectation)
                    .HasColumnType("date")
                    .HasColumnName("dateaffectation");
                entity.Property(e => e.DatenotePead)
                    .HasColumnType("date")
                    .HasColumnName("datenotePead");
                entity.Property(e => e.Daterecrutement)
                    .HasColumnType("date")
                    .HasColumnName("daterecrutement");
                entity.Property(e => e.Daterespons)
                    .HasColumnType("date")
                    .HasColumnName("daterespons");
                entity.Property(e => e.Email).HasMaxLength(50);
                entity.Property(e => e.IdenUniqMatrCnss).HasMaxLength(50);
                entity.Property(e => e.LieuNais).HasMaxLength(50);
                entity.Property(e => e.NomPren).HasMaxLength(250);
                entity.Property(e => e.NotePead)
                    .HasMaxLength(50)
                    .HasColumnName("notePead");
                entity.Property(e => e.NumeCin)
                    .HasMaxLength(10)
                    .HasColumnName("NumeCIN");
                entity.Property(e => e.StructureAttache).HasMaxLength(50);
                entity.Property(e => e.TelGsm)
                    .HasMaxLength(50)
                    .HasColumnName("TelGSM");
            });

            modelBuilder.Entity<PersonnelFormationContinue>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.IdenUniq, e.NumeLign });

                entity.ToTable("Personnel_FormationContinue");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.IdenUniq).HasComment("Identifiant du personnel");
                entity.Property(e => e.NumeLign).HasComment("Nume sequentielle");
                entity.Property(e => e.CodeTypeForm)
                    .HasMaxLength(50)
                    .HasComment("Type formation");
                entity.Property(e => e.DateForm)
                    .HasComment("Date formation")
                    .HasColumnType("datetime");
                entity.Property(e => e.LieuForm)
                    .HasMaxLength(250)
                    .HasComment("Lieu  formation");
                entity.Property(e => e.Orga)
                    .HasMaxLength(250)
                    .HasComment("Organisme");

                entity.HasOne(d => d.CodeTypeFormNavigation).WithMany(p => p.PersonnelFormationContinues)
                    .HasForeignKey(d => d.CodeTypeForm)
                    .HasConstraintName("FK_Personnel_FormationContinue_Nomenclature_TypeFormation");

                entity.HasOne(d => d.PersonnelPersonnel).WithMany(p => p.PersonnelFormationContinues)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol, d.IdenUniq })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personnel_FormationContinue_Personnel_Personnel");
            });

            modelBuilder.Entity<PersonnelPersonnel>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtab, e.AnneScol, e.IdenUniq });

                entity.ToTable("Personnel_Personnel");

                entity.HasIndex(e => e.NumeCin, "NonClusteredIndex-20201231-175555");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .HasComment("Code établissement");
                entity.Property(e => e.AdatenotePead).HasMaxLength(50);
                entity.Property(e => e.AdrePers).HasMaxLength(250);
                entity.Property(e => e.Anci).HasComment("Anciennete (Année)");
                entity.Property(e => e.AnotePead).HasMaxLength(50);
                entity.Property(e => e.CodeCorp)
                    .HasMaxLength(50)
                    .HasComment("Code corps");
                entity.Property(e => e.CodeDele)
                    .HasMaxLength(50)
                    .HasComment("Délégation");
                entity.Property(e => e.CodeDipl)
                    .HasMaxLength(50)
                    .HasComment("Spécialité");
                entity.Property(e => e.CodeFonc)
                    .HasMaxLength(50)
                    .HasComment("Code Fonction");
                entity.Property(e => e.CodeGenr).HasMaxLength(50);
                entity.Property(e => e.CodeGrad)
                    .HasMaxLength(50)
                    .HasComment("Grade");
                entity.Property(e => e.CodeNiveEtud)
                    .HasMaxLength(50)
                    .HasComment("Niveau d'Etude");
                entity.Property(e => e.CodePost).HasMaxLength(50);
                entity.Property(e => e.CodeQual)
                    .HasMaxLength(50)
                    .HasComment("Code qualité");
                entity.Property(e => e.CodeReveMens)
                    .HasMaxLength(50)
                    .HasComment("Code genre");
                entity.Property(e => e.CodeSituFami)
                    .HasMaxLength(50)
                    .HasComment("Situation familiale");
                entity.Property(e => e.CodeSituProf).HasMaxLength(50);
                entity.Property(e => e.CompInfo).HasComment("Complément information");
                entity.Property(e => e.DateCin)
                    .HasColumnType("datetime")
                    .HasColumnName("DateCIN");
                entity.Property(e => e.DateNais).HasColumnType("datetime");
                entity.Property(e => e.Dateaffectation)
                    .HasColumnType("date")
                    .HasColumnName("dateaffectation");
                entity.Property(e => e.DatenotePead)
                    .HasColumnType("date")
                    .HasColumnName("datenotePead");
                entity.Property(e => e.Daterecrutement)
                    .HasColumnType("date")
                    .HasColumnName("daterecrutement");
                entity.Property(e => e.Daterespons)
                    .HasColumnType("date")
                    .HasColumnName("daterespons");
                entity.Property(e => e.Elig).HasComment("Eligible");
                entity.Property(e => e.Email).HasMaxLength(50);
                entity.Property(e => e.IdenUniqMatrCnss).HasMaxLength(50);
                entity.Property(e => e.LieuNais).HasMaxLength(50);
                entity.Property(e => e.NomPren)
                    .HasMaxLength(250)
                    .HasComment("NomPren");
                entity.Property(e => e.NotePead)
                    .HasMaxLength(50)
                    .HasColumnName("notePead");
                entity.Property(e => e.NumeCin)
                    .HasMaxLength(10)
                    .HasColumnName("NumeCIN");
                entity.Property(e => e.Spec).HasComment("Spécialiste");
                entity.Property(e => e.StructureAttache).HasMaxLength(50);
                entity.Property(e => e.TelGsm)
                    .HasMaxLength(50)
                    .HasColumnName("TelGSM");

                entity.HasOne(d => d.CodeCorpNavigation).WithMany(p => p.PersonnelPersonnel)
                    .HasForeignKey(d => d.CodeCorp)
                    .HasConstraintName("FK_Personnel_Personnel_Nomenclature_Corps");

                entity.HasOne(d => d.CodeDeleNavigation).WithMany(p => p.PersonnelPersonnel)
                    .HasForeignKey(d => d.CodeDele)
                    .HasConstraintName("FK_Personnel_Personnel_Nomenclature_Delegation");

                entity.HasOne(d => d.CodeDiplNavigation).WithMany(p => p.PersonnelPersonnel)
                    .HasForeignKey(d => d.CodeDipl)
                    .HasConstraintName("FK_Personnel_Personnel_Nomenclature_Diplome");

                entity.HasOne(d => d.CodeFoncNavigation).WithMany(p => p.PersonnelPersonnel)
                    .HasForeignKey(d => d.CodeFonc)
                    .HasConstraintName("FK_Personnel_Personnel_Nomenclature_Fonction");

                entity.HasOne(d => d.CodeGenrNavigation).WithMany(p => p.PersonnelPersonnel)
                    .HasForeignKey(d => d.CodeGenr)
                    .HasConstraintName("FK_Personnel_Personnel_Nomenclature_Genre");

                entity.HasOne(d => d.CodeGradNavigation).WithMany(p => p.PersonnelPersonnel)
                    .HasForeignKey(d => d.CodeGrad)
                    .HasConstraintName("FK_Personnel_Personnel_Nomenclature_Grade");

                entity.HasOne(d => d.CodeNiveEtudNavigation).WithMany(p => p.PersonnelPersonnel)
                    .HasForeignKey(d => d.CodeNiveEtud)
                    .HasConstraintName("FK_Personnel_Personnel_Nomenclature_NiveauEtude");

                entity.HasOne(d => d.CodeQualNavigation).WithMany(p => p.PersonnelPersonnel)
                    .HasForeignKey(d => d.CodeQual)
                    .HasConstraintName("FK_Personnel_Personnel_Nomenclature_Qualite");

                entity.HasOne(d => d.CodeReveMensNavigation).WithMany(p => p.PersonnelPersonnel)
                    .HasForeignKey(d => d.CodeReveMens)
                    .HasConstraintName("FK_Personnel_Personnel_Nomenclature_RevenuMensuel");

                entity.HasOne(d => d.CodeSituProfNavigation).WithMany(p => p.PersonnelPersonnel)
                    .HasForeignKey(d => d.CodeSituProf)
                    .HasConstraintName("FK__Personnel__CodeS__2779CBAB");
            });

            modelBuilder.Entity<PropositionFiche>(entity =>
            {
                entity.HasKey(e => e.CodePro);

                entity.ToTable("Proposition_fiche");

                entity.Property(e => e.CodePro)
                    .ValueGeneratedNever()
                    .HasColumnName("codePro");
                entity.Property(e => e.CodeTypePro).HasMaxLength(50);
                entity.Property(e => e.Codegouv).HasMaxLength(50);
                entity.Property(e => e.Codeutil).HasMaxLength(50);
                entity.Property(e => e.CodeutilM).HasMaxLength(50);
                entity.Property(e => e.DatePro).HasColumnType("date");
                entity.Property(e => e.Datecreation).HasColumnType("datetime");
                entity.Property(e => e.Datemodification).HasColumnType("datetime");
            });

            modelBuilder.Entity<RapportFichier>(entity =>
            {
                entity.HasKey(e => e.CodeFichier);

                entity.ToTable("Rapport_Fichier");

                entity.Property(e => e.Extension).HasMaxLength(100);
                entity.Property(e => e.NomFichier).HasMaxLength(1000);
            });

            modelBuilder.Entity<ReclamationReclamation>(entity =>
            {
                entity.HasKey(e => new { e.NumeRecl, e.CodeEtab, e.AnneScol });

                entity.ToTable("Reclamation_Reclamation");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.Affe).HasMaxLength(250);
                entity.Property(e => e.CodeEtatRecl).HasMaxLength(50);
                entity.Property(e => e.CodePrio).HasMaxLength(50);
                entity.Property(e => e.DateRecl).HasColumnType("datetime");
                entity.Property(e => e.NomPrenPersRecl).HasMaxLength(250);
                entity.Property(e => e.ObseDeci).HasColumnType("text");
                entity.Property(e => e.Rapp)
                    .UseCollation("Arabic_CI_AS")
                    .HasColumnType("text");
                entity.Property(e => e.Sujet)
                    .UseCollation("Arabic_CI_AS")
                    .HasColumnType("text");

                entity.HasOne(d => d.CodeEtatReclNavigation).WithMany(p => p.ReclamationReclamations)
                    .HasForeignKey(d => d.CodeEtatRecl)
                    .HasConstraintName("FK_Reclamation_Reclamation_Nomenclature_EtatReclamation");

                entity.HasOne(d => d.CodePrioNavigation).WithMany(p => p.ReclamationReclamations)
                    .HasForeignKey(d => d.CodePrio)
                    .HasConstraintName("FK_Reclamation_Reclamation_Nomenclature_Priorite");

                entity.HasOne(d => d.EtablissementFicheEtablissement).WithMany(p => p.ReclamationReclamations)
                    .HasForeignKey(d => new { d.CodeEtab, d.AnneScol })
                    .HasConstraintName("FK_Reclamation_Reclamation_Etablissement_FicheEtablissement");
            });

            modelBuilder.Entity<ReclamationReclamationParent>(entity =>
            {
                entity.HasKey(e => e.NumeRecl);

                entity.ToTable("Reclamation_ReclamationParent");

                entity.Property(e => e.Cin)
                    .HasMaxLength(50)
                    .HasColumnName("CIN");
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeEtatRecl).HasMaxLength(50);
                entity.Property(e => e.CodePrio).HasMaxLength(50);
                entity.Property(e => e.Codeutil)
                    .HasMaxLength(100)
                    .HasComment("Code commerciale (Login)")
                    .HasColumnName("CODEUTIL");
                entity.Property(e => e.DateRecl).HasColumnType("datetime");
                entity.Property(e => e.Email).HasMaxLength(250);
                entity.Property(e => e.NomPren).HasMaxLength(250);
                entity.Property(e => e.Rapp).HasMaxLength(250);
                entity.Property(e => e.Tele).HasMaxLength(50);

                entity.HasOne(d => d.CodeEtabNavigation).WithMany(p => p.ReclamationReclamationParents)
                    .HasForeignKey(d => d.CodeEtab)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reclamation_ReclamationParent_Nomenclature_Etablissement");

                entity.HasOne(d => d.CodeEtatReclNavigation).WithMany(p => p.ReclamationReclamationParents)
                    .HasForeignKey(d => d.CodeEtatRecl)
                    .HasConstraintName("FK_Reclamation_ReclamationParent_Nomenclature_EtatReclamation");

                entity.HasOne(d => d.CodePrioNavigation).WithMany(p => p.ReclamationReclamationParents)
                    .HasForeignKey(d => d.CodePrio)
                    .HasConstraintName("FK_Reclamation_ReclamationParent_Nomenclature_Priorite");

                entity.HasOne(d => d.CodeutilNavigation).WithMany(p => p.ReclamationReclamationParents)
                    .HasForeignKey(d => d.Codeutil)
                    .HasConstraintName("FK_Reclamation_ReclamationParent_SECURITE_UTILISATEUR");
            });

            modelBuilder.Entity<SecuriteAttacheInspecteur>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Securite_AttacheInspecteur");

                entity.Property(e => e.CodeAideInspecteur).HasMaxLength(50);
                entity.Property(e => e.CodeCodeutilAdd)
                    .HasMaxLength(50)
                    .HasColumnName("codeCodeutil_ADD");
                entity.Property(e => e.CodeInspecteur).HasMaxLength(50);
            });

            modelBuilder.Entity<SecuriteDroitaccesgroupe>(entity =>
            {
                entity.HasKey(e => new { e.Codegrouutil, e.Codeenti });

                entity.ToTable("SECURITE_DROITACCESGROUPE");

                entity.Property(e => e.Codegrouutil)
                    .HasMaxLength(100)
                    .HasColumnName("CODEGROUUTIL");
                entity.Property(e => e.Codeenti)
                    .HasMaxLength(100)
                    .HasColumnName("CODEENTI");

                entity.HasOne(d => d.CodeentiNavigation).WithMany(p => p.SecuriteDroitaccesgroupes)
                    .HasForeignKey(d => d.Codeenti)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SECURITE_DROITACCESGROUPE_S");

                entity.HasOne(d => d.CodegrouutilNavigation).WithMany(p => p.SecuriteDroitaccesgroupes)
                    .HasForeignKey(d => d.Codegrouutil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SECURITE_DROITACCESGROUP_26");
            });

            modelBuilder.Entity<SecuriteDroitaccesutilisateur>(entity =>
            {
                entity.HasKey(e => new { e.Codeenti, e.Codeutil }).HasName("PK_SECURITE_DROITACCESUTILISAT");

                entity.ToTable("SECURITE_DROITACCESUTILISATEUR");

                entity.Property(e => e.Codeenti)
                    .HasMaxLength(100)
                    .HasColumnName("CODEENTI");
                entity.Property(e => e.Codeutil)
                    .HasMaxLength(100)
                    .HasColumnName("CODEUTIL");

                entity.HasOne(d => d.CodeentiNavigation).WithMany(p => p.SecuriteDroitaccesutilisateurs)
                    .HasForeignKey(d => d.Codeenti)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SECURITE_DROITACCESUTILISAT");

                entity.HasOne(d => d.CodeutilNavigation).WithMany(p => p.SecuriteDroitaccesutilisateurs)
                    .HasForeignKey(d => d.Codeutil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SECURITE_DROITACCESUTILI_26");
            });

            modelBuilder.Entity<SecuriteEntite>(entity =>
            {
                entity.HasKey(e => e.Codeenti);

                entity.ToTable("SECURITE_ENTITE");

                entity.Property(e => e.Codeenti)
                    .HasMaxLength(100)
                    .HasColumnName("CODEENTI");
                entity.Property(e => e.Codepack)
                    .HasMaxLength(100)
                    .HasColumnName("CODEPACK");
                entity.Property(e => e.Coderangmenu).HasColumnName("CODERANGMENU");
                entity.Property(e => e.Libeenti)
                    .HasMaxLength(500)
                    .HasColumnName("LIBEENTI");
                entity.Property(e => e.Uri)
                    .HasMaxLength(500)
                    .HasColumnName("URI");

                entity.HasOne(d => d.CodepackNavigation).WithMany(p => p.SecuriteEntites)
                    .HasForeignKey(d => d.Codepack)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SECURITE_ENTITE_SECURITE_PA");
            });

            modelBuilder.Entity<SecuriteEtablissement15112020>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Securite_Etablissement_15112020");

                entity.Property(e => e.CodeEtab)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Codeutil)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODEUTIL");
            });

            modelBuilder.Entity<SecuriteEtablissementHistorique>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Securite_Etablissement_historique");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.Codeutil)
                    .HasMaxLength(100)
                    .HasColumnName("CODEUTIL");
            });

            modelBuilder.Entity<SecuriteEtablissementTrace>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Securite_Etablissement_Trace");

                entity.Property(e => e.Codeutil)
                    .HasMaxLength(10)
                    .HasColumnName("codeutil");
                entity.Property(e => e.CodeutilSecurite)
                    .HasMaxLength(10)
                    .HasColumnName("codeutil_securite");
                entity.Property(e => e.Dateoperaion)
                    .HasColumnType("datetime")
                    .HasColumnName("dateoperaion");
                entity.Property(e => e.Detail)
                    .HasMaxLength(4000)
                    .HasColumnName("detail");
                entity.Property(e => e.Operation)
                    .HasMaxLength(10)
                    .HasColumnName("operation");
            });

            modelBuilder.Entity<SecuriteGroupeutilisateur>(entity =>
            {
                entity.HasKey(e => e.Codegrouutil).HasName("PK_SECURTIE_GROUPEUTILISATEUR");

                entity.ToTable("SECURITE_GROUPEUTILISATEUR");

                entity.Property(e => e.Codegrouutil)
                    .HasMaxLength(100)
                    .HasColumnName("CODEGROUUTIL");
                entity.Property(e => e.Acti)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.CodeGrouUtilPare).HasMaxLength(100);
                entity.Property(e => e.Libegrouutil)
                    .HasMaxLength(510)
                    .HasColumnName("LIBEGROUUTIL");
                entity.Property(e => e.Obse)
                    .HasMaxLength(510)
                    .HasColumnName("OBSE");
            });

            modelBuilder.Entity<SecuriteNiveauhierarchique>(entity =>
            {
                entity.HasKey(e => e.Codenivehier);

                entity.ToTable("SECURITE_NIVEAUHIERARCHIQUE");

                entity.Property(e => e.Codenivehier)
                    .HasMaxLength(100)
                    .HasColumnName("CODENIVEHIER");
                entity.Property(e => e.Acti)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.Libenivehier)
                    .HasMaxLength(510)
                    .HasColumnName("LIBENIVEHIER");
            });

            modelBuilder.Entity<SecuritePackage>(entity =>
            {
                entity.HasKey(e => e.Codepack);

                entity.ToTable("SECURITE_PACKAGE");

                entity.Property(e => e.Codepack)
                    .HasMaxLength(100)
                    .HasColumnName("CODEPACK");
                entity.Property(e => e.Libepack)
                    .HasMaxLength(100)
                    .HasColumnName("LIBEPACK");
                entity.Property(e => e.Ordraffi).HasColumnName("ORDRAFFI");
                entity.Property(e => e.Uri)
                    .HasMaxLength(500)
                    .HasColumnName("URI");
            });

            modelBuilder.Entity<SecuriteSessionUtilisateur>(entity =>
            {
                entity.HasKey(e => e.CodeUtil).HasName("PK_Securite_SessionUtilisateur_1");

                entity.ToTable("Securite_SessionUtilisateur");

                entity.Property(e => e.CodeUtil).HasMaxLength(100);
                entity.Property(e => e.DateCurrSess).HasColumnType("datetime");
                entity.Property(e => e.DateDebuLastSess).HasColumnType("datetime");
                entity.Property(e => e.DateFinLastSess).HasColumnType("datetime");
                entity.Property(e => e.IpAdre).HasMaxLength(50);
                entity.Property(e => e.LastIpAdre).HasMaxLength(50);

                entity.HasOne(d => d.CodeUtilNavigation).WithOne(p => p.SecuriteSessionUtilisateur)
                    .HasForeignKey<SecuriteSessionUtilisateur>(d => d.CodeUtil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Securite_SessionUtilisateur_SECURITE_UTILISATEUR");
            });

            modelBuilder.Entity<SecuriteSiganlisation>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Securite_Siganlisation");

                entity.Property(e => e.Codeutil)
                    .HasMaxLength(50)
                    .HasColumnName("codeutil");
                entity.Property(e => e.Valeur)
                    .HasMaxLength(50)
                    .HasColumnName("valeur");
            });

            modelBuilder.Entity<SecuriteTraceutilisateur>(entity =>
            {
                entity.HasKey(e => e.Numetrac);

                entity.ToTable("SECURITE_TRACEUTILISATEUR");

                entity.Property(e => e.Numetrac)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("NUMETRAC");
                entity.Property(e => e.Codeenti)
                    .HasMaxLength(100)
                    .HasColumnName("CODEENTI");
                entity.Property(e => e.Codetypeoper)
                    .HasMaxLength(100)
                    .HasColumnName("CODETYPEOPER");
                entity.Property(e => e.Codeutil)
                    .HasMaxLength(100)
                    .HasColumnName("CODEUTIL");
                entity.Property(e => e.Datetrac)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETRAC");
                entity.Property(e => e.Libetrac)
                    .HasMaxLength(1000)
                    .HasColumnName("LIBETRAC");
                entity.Property(e => e.Linktrac)
                    .HasMaxLength(300)
                    .HasColumnName("LINKTRAC");
                entity.Property(e => e.Pkenti)
                    .HasMaxLength(200)
                    .HasColumnName("PKENTI");

                entity.HasOne(d => d.CodetypeoperNavigation).WithMany(p => p.SecuriteTraceutilisateurs)
                    .HasForeignKey(d => d.Codetypeoper)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SECURITE_TRACEUTILISATEUR_SECURITE_TYPEOPERATIONTRACE");

                entity.HasOne(d => d.CodeutilNavigation).WithMany(p => p.SecuriteTraceutilisateurs)
                    .HasForeignKey(d => d.Codeutil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SECURITE_TRACEUTILISATEUR_S");
            });

            modelBuilder.Entity<SecuriteTypeoperationtrace>(entity =>
            {
                entity.HasKey(e => e.Codetypeopertrac);

                entity.ToTable("SECURITE_TYPEOPERATIONTRACE");

                entity.Property(e => e.Codetypeopertrac)
                    .HasMaxLength(100)
                    .HasColumnName("CODETYPEOPERTRAC");
                entity.Property(e => e.Libetypeopertrac)
                    .HasMaxLength(500)
                    .HasColumnName("LIBETYPEOPERTRAC");
                entity.Property(e => e.Obse)
                    .HasMaxLength(500)
                    .HasColumnName("OBSE");
            });

            modelBuilder.Entity<SecuriteUtilisateur>(entity =>
            {
                entity.HasKey(e => e.Codeutil);

                entity.ToTable("SECURITE_UTILISATEUR");

                entity.Property(e => e.Codeutil)
                    .HasMaxLength(100)
                    .HasComment("Code commerciale (Login)")
                    .HasColumnName("CODEUTIL");
                entity.Property(e => e.CodeCerc).HasMaxLength(50);
                entity.Property(e => e.CodeCommFonc)
                    .HasMaxLength(50)
                    .HasComment("Code type standing");
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeUtilPare).HasMaxLength(100);
                entity.Property(e => e.Codegrouutil)
                    .HasMaxLength(100)
                    .HasComment("Groupe utilisateur")
                    .HasColumnName("CODEGROUUTIL");
                entity.Property(e => e.Codenivehier)
                    .HasMaxLength(100)
                    .HasComment("Niveau hierarchique")
                    .HasColumnName("CODENIVEHIER");
                entity.Property(e => e.Codeutiladd)
                    .HasMaxLength(50)
                    .HasColumnName("codeutiladd");
                entity.Property(e => e.Codeutilupdate)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilupdate");
                entity.Property(e => e.Dateadduser)
                    .HasColumnType("datetime")
                    .HasColumnName("dateadduser");
                entity.Property(e => e.Datemaj)
                    .HasComment("Date de dernier MAJ")
                    .HasColumnType("datetime")
                    .HasColumnName("DATEMAJ");
                entity.Property(e => e.Dateupdateuser)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdateuser");
                entity.Property(e => e.Email).HasMaxLength(250);
                entity.Property(e => e.Etat)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.Gsm)
                    .HasMaxLength(50)
                    .HasColumnName("GSM");
                entity.Property(e => e.Matr)
                    .HasMaxLength(100)
                    .HasComment("Matricule")
                    .HasColumnName("MATR");
                entity.Property(e => e.Motpassutil)
                    .HasComment("Mot de passe")
                    .HasColumnName("MOTPASSUTIL");
                entity.Property(e => e.Nomprenutil)
                    .HasMaxLength(100)
                    .HasComment("Nom et prénom")
                    .HasColumnName("NOMPRENUTIL");
                entity.Property(e => e.SkypeId)
                    .HasMaxLength(50)
                    .HasColumnName("SkypeID");
                entity.Property(e => e.Tele)
                    .HasMaxLength(50)
                    .HasComment("Téléphone / GSM");

                entity.HasOne(d => d.CodegrouutilNavigation).WithMany(p => p.SecuriteUtilisateurs)
                    .HasForeignKey(d => d.Codegrouutil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SECURITE_UTILISATEUR_SECURT");

                entity.HasOne(d => d.CodenivehierNavigation).WithMany(p => p.SecuriteUtilisateurs)
                    .HasForeignKey(d => d.Codenivehier)
                    .HasConstraintName("FK_SECURITE_UTILISATEUR_SECURI");

                entity.HasMany(d => d.CodeEtabs).WithMany(p => p.Codeutils)
                    .UsingEntity<Dictionary<string, object>>(
                        "SecuriteEtablissement",
                        r => r.HasOne<NomenclatureEtablissement>().WithMany()
                            .HasForeignKey("CodeEtab")
                            .HasConstraintName("FK_Securite_Etablissement_Nomenclature_Etablissement"),
                        l => l.HasOne<SecuriteUtilisateur>().WithMany()
                            .HasForeignKey("Codeutil")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_Securite_Etablissement_SECURITE_UTILISATEUR"),
                        j =>
                        {
                            j.HasKey("Codeutil", "CodeEtab");
                            j.ToTable("Securite_Etablissement");
                            j.IndexerProperty<string>("Codeutil")
                                .HasMaxLength(100)
                                .HasComment("Code commerciale (Login)")
                                .HasColumnName("CODEUTIL");
                            j.IndexerProperty<string>("CodeEtab")
                                .HasMaxLength(50)
                                .HasComment("Code établissement");
                        });
            });

            modelBuilder.Entity<SignalisationFichier>(entity =>
            {
                entity.HasKey(e => e.CodeFichier);

                entity.ToTable("Signalisation_Fichier");

                entity.Property(e => e.Extension).HasMaxLength(100);
                entity.Property(e => e.NomFichier).HasMaxLength(1000);
            });

            modelBuilder.Entity<SignalisationFichierRpt>(entity =>
            {
                entity.HasKey(e => e.CodeFichier);

                entity.ToTable("Signalisation_Fichier_Rpt");

                entity.Property(e => e.Extension).HasMaxLength(100);
                entity.Property(e => e.NomFichier).HasMaxLength(1000);
            });

            modelBuilder.Entity<SignalisationNatureAnomalie>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Signalisation_NatureAnomalie");

                entity.Property(e => e.CodeNatureAnomalie).HasMaxLength(50);
            });

            modelBuilder.Entity<SignatureFichier>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Signature_Fichier");

                entity.Property(e => e.Codeutil)
                    .HasMaxLength(50)
                    .HasColumnName("codeutil");
            });

            modelBuilder.Entity<ViewActivite>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_activite");

                entity.Property(e => e.CodeAct).HasColumnName("codeAct");
                entity.Property(e => e.CodeNatAct).HasMaxLength(50);
                entity.Property(e => e.CodeSecFor).HasMaxLength(50);
                entity.Property(e => e.Codegouv).HasMaxLength(50);
                entity.Property(e => e.Codeutil).HasMaxLength(50);
                entity.Property(e => e.CodeutilM).HasMaxLength(50);
                entity.Property(e => e.Codeutilrapport)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilrapport");
                entity.Property(e => e.DateAct).HasColumnType("date");
                entity.Property(e => e.Datecreation).HasColumnType("datetime");
                entity.Property(e => e.Datemodification).HasColumnType("datetime");
                entity.Property(e => e.Daterapport)
                    .HasColumnType("datetime")
                    .HasColumnName("daterapport");
                entity.Property(e => e.LibeNatAct).HasMaxLength(250);
                entity.Property(e => e.Libegouv)
                    .HasMaxLength(50)
                    .HasColumnName("libegouv");
                entity.Property(e => e.LibesecFor).HasMaxLength(250);
                entity.Property(e => e.Moisactivite)
                    .HasMaxLength(61)
                    .HasColumnName("moisactivite");
                entity.Property(e => e.Participant).HasMaxLength(500);
            });

            modelBuilder.Entity<ViewAnomalie>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Anomalie");

                entity.Property(e => e.CodeAnom).HasMaxLength(50);
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.DatefinAn)
                    .HasColumnType("date")
                    .HasColumnName("datefinAn");
                entity.Property(e => e.LibeCommEtab).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
                entity.Property(e => e.Libeanom)
                    .HasMaxLength(250)
                    .HasColumnName("libeanom");
                entity.Property(e => e.Libegouv)
                    .HasMaxLength(50)
                    .HasColumnName("libegouv");
            });

            modelBuilder.Entity<ViewCommune>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Commune");

                entity.Property(e => e.CodeComm).HasMaxLength(50);
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewEnfantS1>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_Enfant_S1");

                entity.Property(e => e.Annescol).HasColumnName("annescol");
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeDele)
                    .HasMaxLength(50)
                    .HasColumnName("libeDele");
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<ViewEnfantS10>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_Enfant_S10");

                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.Methode).HasMaxLength(50);
                entity.Property(e => e.Nombre).HasColumnName("nombre");
                entity.Property(e => e.TypeEtablissement).HasMaxLength(50);
                entity.Property(e => e.TypeSign).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewEnfantS2>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_Enfant_S2");

                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeSect).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.Couverture).HasColumnName("couverture");
                entity.Property(e => e.Genre)
                    .HasMaxLength(2)
                    .IsUnicode(false);
                entity.Property(e => e.LibeDele)
                    .HasMaxLength(50)
                    .HasColumnName("libeDele");
                entity.Property(e => e.LibeGenr).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<ViewEnfantS3>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_Enfant_S3");

                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeDele)
                    .HasMaxLength(50)
                    .HasColumnName("libeDele");
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypePrisChar).HasMaxLength(50);
                entity.Property(e => e.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<ViewEnfantS4>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_Enfant_S4");

                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeSect).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeDele)
                    .HasMaxLength(50)
                    .HasColumnName("libeDele");
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewEnfantS5>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_Enfant_S5");

                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeDele)
                    .HasMaxLength(50)
                    .HasColumnName("libeDele");
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.Libesect).HasMaxLength(50);
                entity.Property(e => e.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<ViewEnfantS6>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_Enfant_S6");

                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeDele)
                    .HasMaxLength(50)
                    .HasColumnName("libeDele");
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.NombreEtab).HasColumnName("nombreEtab");
                entity.Property(e => e.NombreP).HasColumnName("nombreP");
            });

            modelBuilder.Entity<ViewEnfantS7>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_Enfant_S7");

                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.Genre)
                    .HasMaxLength(2)
                    .IsUnicode(false);
                entity.Property(e => e.LibeDele)
                    .HasMaxLength(50)
                    .HasColumnName("libeDele");
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.Libegenr)
                    .HasMaxLength(50)
                    .HasColumnName("libegenr");
                entity.Property(e => e.Libetranage)
                    .HasMaxLength(250)
                    .HasColumnName("libetranage");
                entity.Property(e => e.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<ViewEnfantS8>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_Enfant_S8");

                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.Libetypehand)
                    .HasMaxLength(250)
                    .HasColumnName("libetypehand");
                entity.Property(e => e.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<ViewEnfantS9>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_Enfant_S9");

                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeDele)
                    .HasMaxLength(50)
                    .HasColumnName("libeDele");
                entity.Property(e => e.LibeGenr).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeZone)
                    .HasMaxLength(50)
                    .HasColumnName("libeZone");
                entity.Property(e => e.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<ViewEquipement>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Equipement");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEqui).HasMaxLength(1000);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewEspace>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Espace");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEspa).HasMaxLength(250);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewEspaceCaracteristique>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Espace_Caracteristique");

                entity.Property(e => e.CodeCaraEspa).HasMaxLength(50);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.ConfCara)
                    .HasMaxLength(12)
                    .IsUnicode(false);
                entity.Property(e => e.LibeCaraEspa).HasMaxLength(250);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEspa).HasMaxLength(250);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewEtablissement>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Etablissement");

                entity.Property(e => e.AdreEtab).HasMaxLength(100);
                entity.Property(e => e.Anneecreation).HasColumnName("anneecreation");
                entity.Property(e => e.Cadreinspection).HasMaxLength(500);
                entity.Property(e => e.CausFerm).HasMaxLength(500);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodePost).HasMaxLength(50);
                entity.Property(e => e.DateDemaActi).HasColumnType("datetime");
                entity.Property(e => e.DateFerm).HasColumnType("datetime");
                entity.Property(e => e.DepoCahiCharPrep).HasMaxLength(3);
                entity.Property(e => e.Email).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeCommEtab).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDiplDire).HasMaxLength(500);
                entity.Property(e => e.LibeDiplFond).HasMaxLength(500);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeFoncDire).HasMaxLength(50);
                entity.Property(e => e.LibeGenrDire).HasMaxLength(50);
                entity.Property(e => e.LibeGenrFond).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeGradDire).HasMaxLength(250);
                entity.Property(e => e.LibeNiveEtudDire).HasMaxLength(50);
                entity.Property(e => e.LibeNiveEtudFond).HasMaxLength(50);
                entity.Property(e => e.LibeOuveEtab).HasMaxLength(50);
                entity.Property(e => e.LibeQualDire).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeSituFamiDire).HasMaxLength(50);
                entity.Property(e => e.LibeSituFamiFond).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
                entity.Property(e => e.LieuNaisFond).HasMaxLength(50);
                entity.Property(e => e.MoisDeciOuvr).HasMaxLength(30);
                entity.Property(e => e.MoisFerm).HasMaxLength(30);
                entity.Property(e => e.NomPrenDire).HasMaxLength(250);
                entity.Property(e => e.NomPrenFond).HasMaxLength(50);
                entity.Property(e => e.NumeCindire)
                    .HasMaxLength(10)
                    .HasColumnName("NumeCINDire");
                entity.Property(e => e.NumePiecIden).HasMaxLength(50);
                entity.Property(e => e.QuarFerm)
                    .HasMaxLength(14)
                    .IsUnicode(false);
                entity.Property(e => e.Tele).HasMaxLength(45);
            });

            modelBuilder.Entity<ViewEtablissementUtilisateurByGouv>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_EtablissementUtilisateurByGouv");

                entity.Property(e => e.LibeGouv).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewEvent>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_event");

                entity.Property(e => e.CodeEvent).HasColumnName("codeEvent");
                entity.Property(e => e.CodeNivFor).HasMaxLength(50);
                entity.Property(e => e.CodeSecFor).HasMaxLength(50);
                entity.Property(e => e.Codegouv).HasMaxLength(50);
                entity.Property(e => e.Codeutil).HasMaxLength(50);
                entity.Property(e => e.CodeutilM).HasMaxLength(50);
                entity.Property(e => e.Codeutilrapport)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilrapport");
                entity.Property(e => e.DateEvent).HasColumnType("date");
                entity.Property(e => e.Datecreation).HasColumnType("datetime");
                entity.Property(e => e.Datemodification).HasColumnType("datetime");
                entity.Property(e => e.Daterapport)
                    .HasColumnType("datetime")
                    .HasColumnName("daterapport");
                entity.Property(e => e.InvesEvent).HasMaxLength(50);
                entity.Property(e => e.LibeNatInv).HasMaxLength(250);
                entity.Property(e => e.LibeNivFor).HasMaxLength(250);
                entity.Property(e => e.Libegouv)
                    .HasMaxLength(50)
                    .HasColumnName("libegouv");
                entity.Property(e => e.LibesecFor).HasMaxLength(250);
                entity.Property(e => e.Moisevent)
                    .HasMaxLength(61)
                    .HasColumnName("moisevent");
                entity.Property(e => e.Participant).HasMaxLength(500);
                entity.Property(e => e.PrixEvent).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewFicheEtablissement>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_FicheEtablissement");

                entity.Property(e => e.AdreEtab).HasMaxLength(100);
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeOuveEtab).HasMaxLength(50);
                entity.Property(e => e.CodePersDire).HasMaxLength(50);
                entity.Property(e => e.CodePost).HasMaxLength(50);
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMail");
                entity.Property(e => e.Fax).HasMaxLength(50);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.SiteWeb).HasMaxLength(200);
                entity.Property(e => e.TeleFixe).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewFormation>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_formation");

                entity.Property(e => e.CodeCerc).HasMaxLength(50);
                entity.Property(e => e.CodeNatFor).HasMaxLength(50);
                entity.Property(e => e.CodeNatFormateur).HasMaxLength(50);
                entity.Property(e => e.CodeNivFor).HasMaxLength(50);
                entity.Property(e => e.CodeSecFor).HasMaxLength(50);
                entity.Property(e => e.Codeformation).HasColumnName("codeformation");
                entity.Property(e => e.Codegouv).HasMaxLength(50);
                entity.Property(e => e.Codeutil).HasMaxLength(50);
                entity.Property(e => e.CodeutilM).HasMaxLength(50);
                entity.Property(e => e.Codeutilrapport)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilrapport");
                entity.Property(e => e.Datecreation).HasColumnType("datetime");
                entity.Property(e => e.Dateformation).HasColumnType("date");
                entity.Property(e => e.Datemodification).HasColumnType("datetime");
                entity.Property(e => e.Daterapport)
                    .HasColumnType("datetime")
                    .HasColumnName("daterapport");
                entity.Property(e => e.Inspecteur).HasMaxLength(50);
                entity.Property(e => e.InvesFormation).HasMaxLength(50);
                entity.Property(e => e.LibeFormateur).HasMaxLength(250);
                entity.Property(e => e.LibeNatFor).HasMaxLength(250);
                entity.Property(e => e.LibeSecFor).HasMaxLength(250);
                entity.Property(e => e.Libegouv)
                    .HasMaxLength(50)
                    .HasColumnName("libegouv");
                entity.Property(e => e.Libenatinv).HasMaxLength(250);
                entity.Property(e => e.Libenivfor)
                    .HasMaxLength(250)
                    .HasColumnName("libenivfor");
                entity.Property(e => e.ListeTypeEtab)
                    .HasMaxLength(500)
                    .HasColumnName("listeTypeEtab");
                entity.Property(e => e.Listecorps)
                    .HasMaxLength(500)
                    .HasColumnName("listecorps");
                entity.Property(e => e.Moisformation)
                    .HasMaxLength(61)
                    .HasColumnName("moisformation");
                entity.Property(e => e.NomFormateur).HasMaxLength(50);
                entity.Property(e => e.NomprenutilInsp)
                    .HasMaxLength(100)
                    .HasColumnName("nomprenutilInsp");
                entity.Property(e => e.Participant)
                    .HasMaxLength(1)
                    .IsUnicode(false);
                entity.Property(e => e.PerOrg).HasMaxLength(500);
                entity.Property(e => e.PrixFormation).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewFormationContenue>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_FormationContenue");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.DateForm).HasColumnType("datetime");
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeTypeForm).HasMaxLength(250);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
                entity.Property(e => e.LieuForm).HasMaxLength(250);
                entity.Property(e => e.NomPren).HasMaxLength(250);
                entity.Property(e => e.Orga).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewFormationNationale>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_formation_Nationale");

                entity.Property(e => e.CodeCerc).HasMaxLength(50);
                entity.Property(e => e.CodeNatFor).HasMaxLength(50);
                entity.Property(e => e.CodeNatFormateur).HasMaxLength(50);
                entity.Property(e => e.CodeNivFor).HasMaxLength(50);
                entity.Property(e => e.CodeSecFor).HasMaxLength(50);
                entity.Property(e => e.Codeformation).HasColumnName("codeformation");
                entity.Property(e => e.Codegouv).HasMaxLength(50);
                entity.Property(e => e.Codeutil).HasMaxLength(50);
                entity.Property(e => e.CodeutilM).HasMaxLength(50);
                entity.Property(e => e.Codeutilrapport)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilrapport");
                entity.Property(e => e.Datecreation).HasColumnType("datetime");
                entity.Property(e => e.Dateformation).HasColumnType("date");
                entity.Property(e => e.Datemodification).HasColumnType("datetime");
                entity.Property(e => e.Daterapport)
                    .HasColumnType("datetime")
                    .HasColumnName("daterapport");
                entity.Property(e => e.Inspecteur).HasMaxLength(50);
                entity.Property(e => e.InvesFormation).HasMaxLength(50);
                entity.Property(e => e.LibeFormateur).HasMaxLength(250);
                entity.Property(e => e.LibeNatFor).HasMaxLength(250);
                entity.Property(e => e.LibeSecFor).HasMaxLength(250);
                entity.Property(e => e.Libegouv)
                    .HasMaxLength(50)
                    .HasColumnName("libegouv");
                entity.Property(e => e.Libenatinv).HasMaxLength(250);
                entity.Property(e => e.Libenivfor)
                    .HasMaxLength(250)
                    .HasColumnName("libenivfor");
                entity.Property(e => e.ListeTypeEtab)
                    .HasMaxLength(500)
                    .HasColumnName("listeTypeEtab");
                entity.Property(e => e.Listecorps)
                    .HasMaxLength(500)
                    .HasColumnName("listecorps");
                entity.Property(e => e.Moisformation)
                    .HasMaxLength(61)
                    .HasColumnName("moisformation");
                entity.Property(e => e.NomFormateur).HasMaxLength(50);
                entity.Property(e => e.NomprenutilInsp)
                    .HasMaxLength(100)
                    .HasColumnName("nomprenutilInsp");
                entity.Property(e => e.Participant)
                    .HasMaxLength(1)
                    .IsUnicode(false);
                entity.Property(e => e.PerOrg).HasMaxLength(500);
                entity.Property(e => e.PrixFormation).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewFormationRapport>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_formation_rapport");

                entity.Property(e => e.Codeformation).HasColumnName("codeformation");
                entity.Property(e => e.Dateformation).HasColumnType("date");
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.Nomformateur)
                    .HasMaxLength(50)
                    .HasColumnName("nomformateur");
                entity.Property(e => e.NomprenutilInsp)
                    .HasMaxLength(100)
                    .HasColumnName("nomprenutilInsp");
                entity.Property(e => e.Observation).HasColumnName("observation");
                entity.Property(e => e.PerOrg).HasMaxLength(500);
            });

            modelBuilder.Entity<ViewInfrastructure>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Infrastructure");

                entity.Property(e => e.Clot).HasMaxLength(50);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.ConnInte).HasMaxLength(50);
                entity.Property(e => e.HautClot)
                    .HasMaxLength(13)
                    .IsUnicode(false);
                entity.Property(e => e.Lib1)
                    .HasMaxLength(3)
                    .HasColumnName("lib1");
                entity.Property(e => e.Lib2)
                    .HasMaxLength(3)
                    .HasColumnName("lib2");
                entity.Property(e => e.Lib3)
                    .HasMaxLength(3)
                    .HasColumnName("lib3");
                entity.Property(e => e.Lib4)
                    .HasMaxLength(3)
                    .HasColumnName("lib4");
                entity.Property(e => e.LibeCaraEspaExte).HasMaxLength(250);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEmpl).HasMaxLength(250);
                entity.Property(e => e.LibeEmplSieg).HasMaxLength(250);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeRegiProp).HasMaxLength(250);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeClot).HasMaxLength(250);
                entity.Property(e => e.LibeTypeConnInte).HasMaxLength(250);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeTypeProp).HasMaxLength(250);
                entity.Property(e => e.LibeZone)
                    .HasMaxLength(50)
                    .HasColumnName("libeZone");
                entity.Property(e => e.PassSpecPersBesoSpec).HasMaxLength(50);
                entity.Property(e => e.SurfBati)
                    .HasMaxLength(13)
                    .IsUnicode(false);
                entity.Property(e => e.SurfEspaExte)
                    .HasMaxLength(13)
                    .IsUnicode(false);
                entity.Property(e => e.SurfTota)
                    .HasMaxLength(13)
                    .IsUnicode(false);
                entity.Property(e => e.SurfaceTerrain).HasMaxLength(50);
                entity.Property(e => e.TeleFixe).HasMaxLength(50);
                entity.Property(e => e.Terrain).HasMaxLength(3);
                entity.Property(e => e.TypeTerrain).HasMaxLength(500);
            });

            modelBuilder.Entity<ViewInfrastructureAutre>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Infrastructure_Autre");

                entity.Property(e => e.Checked).HasColumnName("checked");
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodetypeInfra).HasMaxLength(50);
                entity.Property(e => e.Lbchecked)
                    .HasMaxLength(3)
                    .HasColumnName("LBChecked");
                entity.Property(e => e.LibeInfrastrcture).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewInspection>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection");

                entity.Property(e => e.CodeCommFonc).HasMaxLength(50);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.DateVisiInsp).HasColumnType("date");
                entity.Property(e => e.DeduGene).UseCollation("Arabic_CI_AS");
                entity.Property(e => e.DetaAnom).HasMaxLength(500);
                entity.Property(e => e.LibeTypeInsp).HasMaxLength(250);
                entity.Property(e => e.Libegrouutil)
                    .HasMaxLength(510)
                    .HasColumnName("LIBEGROUUTIL");
                entity.Property(e => e.Matr)
                    .HasMaxLength(100)
                    .HasColumnName("MATR");
                entity.Property(e => e.Nomprenutil)
                    .HasMaxLength(100)
                    .HasColumnName("NOMPRENUTIL");
                entity.Property(e => e.RemaSuivActi).HasColumnName("RemaSuiv_Acti");
                entity.Property(e => e.RemaSuivCondSecu).HasColumnName("RemaSuiv_CondSecu");
                entity.Property(e => e.RemaSuivInfr).HasColumnName("RemaSuiv_Infr");
                entity.Property(e => e.RemaSuivPers).HasColumnName("RemaSuiv_Pers");
                entity.Property(e => e.RemaSuivProgPeda).HasColumnName("RemaSuiv_ProgPeda");
                entity.Property(e => e.RemaSuivSujet)
                    .HasMaxLength(100)
                    .HasColumnName("RemaSuiv_Sujet");
            });

            modelBuilder.Entity<ViewInspectionClub>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_Club");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTypeClub).HasMaxLength(50);
                entity.Property(e => e.LibeClub).HasMaxLength(250);
                entity.Property(e => e.Nbseance).HasColumnName("nbseance");
                entity.Property(e => e.PrixClub).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewInspectionEnfantNe>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_EnfantNE");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.DateNais).HasMaxLength(30);
                entity.Property(e => e.Dateinscrit)
                    .HasMaxLength(30)
                    .HasColumnName("dateinscrit");
                entity.Property(e => e.Idenfant).HasColumnName("idenfant");
                entity.Property(e => e.Nompere)
                    .HasMaxLength(50)
                    .HasColumnName("nompere");
                entity.Property(e => e.Nomprenom)
                    .HasMaxLength(50)
                    .HasColumnName("nomprenom");
                entity.Property(e => e.NumTel).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewInspectionEquipement>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_Equipement");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEqui).HasMaxLength(1000);
            });

            modelBuilder.Entity<ViewInspectionEspace>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_espace");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEspa).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewInspectionInfoGenerale>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_InfoGenerale");

                entity.Property(e => e.AdreEtab).HasMaxLength(100);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodePost).HasMaxLength(50);
                entity.Property(e => e.DateCrea).HasColumnType("datetime");
                entity.Property(e => e.DateDepoCahiChar).HasColumnType("datetime");
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.NomPrenDire).HasMaxLength(250);
                entity.Property(e => e.NomPrenFond).HasMaxLength(50);
                entity.Property(e => e.NumePiecIden).HasMaxLength(50);
                entity.Property(e => e.NumePiecIdenDire).HasMaxLength(10);
                entity.Property(e => e.TeleFixe).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewInspectionInfrastructure>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_Infrastructure");

                entity.Property(e => e.AutrEmplSieg).HasMaxLength(500);
                entity.Property(e => e.CodeEmplSieg).HasMaxLength(50);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.ExistTerrain).HasColumnName("existTerrain");
                entity.Property(e => e.LibeCaraEspaExte).HasMaxLength(250);
                entity.Property(e => e.LibeEmpl).HasMaxLength(250);
                entity.Property(e => e.LibeEmplSieg).HasMaxLength(250);
                entity.Property(e => e.LibeTerrain).HasMaxLength(500);
                entity.Property(e => e.LibeTypeClot).HasMaxLength(250);
                entity.Property(e => e.LibeTypeConnInte).HasMaxLength(250);
                entity.Property(e => e.LibeTypeProp).HasMaxLength(250);
                entity.Property(e => e.SurfaceTerrain).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewInspectionInfrastructureAutre>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_Infrastructure_Autre");

                entity.Property(e => e.Checked).HasColumnName("checked");
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodetypeInfra).HasMaxLength(50);
                entity.Property(e => e.Lbchecked)
                    .HasMaxLength(3)
                    .HasColumnName("LBChecked");
                entity.Property(e => e.LibeInfrastrcture).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewInspectionIntervention>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_intervention");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeInterv).HasMaxLength(50);
                entity.Property(e => e.CodeTypeInterv).HasMaxLength(50);
                entity.Property(e => e.LibeInterv).HasMaxLength(250);
                entity.Property(e => e.LibeTypeInterv).HasMaxLength(250);
                entity.Property(e => e.Observation).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewInspectionLienexterne>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_Lienexterne");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeLienExterne).HasMaxLength(50);
                entity.Property(e => e.LibeLienExterne).HasMaxLength(250);
                entity.Property(e => e.Observation).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewInspectionOrganisationAdministrative>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_OrganisationAdministrative");

                entity.Property(e => e.Ajour).HasColumnName("AJour");
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeOrgaAdmi).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewInspectionOrganisationPedagogique>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_OrganisationPedagogique");

                entity.Property(e => e.Ajour).HasColumnName("AJour");
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeOrgaPeda).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewInspectionRepartitionHandicap>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_RepartitionHandicap");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeHand).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewInspectionRepartitionPersonel>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_RepartitionPersonel");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.DateNais).HasColumnType("date");
                entity.Property(e => e.Dateaffectation)
                    .HasColumnType("date")
                    .HasColumnName("dateaffectation");
                entity.Property(e => e.DatenotePead)
                    .HasMaxLength(4000)
                    .HasColumnName("datenotePead");
                entity.Property(e => e.Daterecrutement)
                    .HasColumnType("date")
                    .HasColumnName("daterecrutement");
                entity.Property(e => e.Daterespons)
                    .HasColumnType("date")
                    .HasColumnName("daterespons");
                entity.Property(e => e.IdenUniqMatrCnss).HasMaxLength(50);
                entity.Property(e => e.LibeFonc).HasMaxLength(50);
                entity.Property(e => e.LibeGenr).HasMaxLength(50);
                entity.Property(e => e.LibeGrad).HasMaxLength(250);
                entity.Property(e => e.LibeNiveEtud).HasMaxLength(50);
                entity.Property(e => e.NomPren).HasMaxLength(250);
                entity.Property(e => e.NotePead)
                    .HasMaxLength(50)
                    .HasColumnName("notePead");
                entity.Property(e => e.StructureAttache).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewInspectionRepartitionPersonelFonction>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_RepartitionPersonelFonction");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeFonc).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewInspectionRepartitionTrancheAge>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_RepartitionTrancheAge");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);
                entity.Property(e => e.LibeTranAge).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewInspectionRepartitionTrancheAgeArretEtude>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_RepartitionTrancheAgeArretEtude");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);
                entity.Property(e => e.LibeTranAge).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewInspectionRepartitionTrancheAgeBeneficaire>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_RepartitionTrancheAgeBeneficaire");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);
                entity.Property(e => e.LibeTranAge).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewInspectionRepartitionTrancheAgeTypePriseEnCharge>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_RepartitionTrancheAgeTypePriseEnCharge");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTranAge).HasMaxLength(50);
                entity.Property(e => e.CodeTypePrisChar).HasMaxLength(50);
                entity.Property(e => e.LibeTranAge).HasMaxLength(250);
                entity.Property(e => e.LibeTypePrisChar)
                    .HasMaxLength(50)
                    .HasColumnName("libeTypePrisChar");
            });

            modelBuilder.Entity<ViewInspectionRepartitionTypePriseEnCharge>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_RepartitionTypePriseEnCharge");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTypePrisChar).HasMaxLength(50);
                entity.Property(e => e.LibeTypePrisChar)
                    .HasMaxLength(50)
                    .HasColumnName("libeTypePrisChar");
            });

            modelBuilder.Entity<ViewInspectionStat>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inspection_Stat");

                entity.Property(e => e.Code).HasMaxLength(110);
                entity.Property(e => e.CodeComm).HasMaxLength(50);
                entity.Property(e => e.CodeCommFonc).HasMaxLength(50);
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.DateVisiInsp).HasColumnType("date");
                entity.Property(e => e.DeduGene).UseCollation("Arabic_CI_AS");
                entity.Property(e => e.JourSemaVisiInsp).HasMaxLength(63);
                entity.Property(e => e.JourVisiInsp)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeRect).HasMaxLength(250);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeTypeInsp).HasMaxLength(250);
                entity.Property(e => e.LibeZone)
                    .HasMaxLength(50)
                    .HasColumnName("libeZone");
                entity.Property(e => e.Libegrouutil)
                    .HasMaxLength(510)
                    .HasColumnName("LIBEGROUUTIL");
                entity.Property(e => e.Matr)
                    .HasMaxLength(100)
                    .HasColumnName("MATR");
                entity.Property(e => e.MoisVisiInsp).HasMaxLength(4000);
                entity.Property(e => e.NomInspecteur2).HasMaxLength(100);
                entity.Property(e => e.Nomprenutil)
                    .HasMaxLength(100)
                    .HasColumnName("NOMPRENUTIL");
                entity.Property(e => e.Personnel).HasMaxLength(250);
                entity.Property(e => e.QuarVisiInsp)
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewIntervention>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Intervention");

                entity.Property(e => e.Checked).HasColumnName("checked");
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeInterv).HasMaxLength(50);
                entity.Property(e => e.LibeCommEtab).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
                entity.Property(e => e.Libegouv)
                    .HasMaxLength(50)
                    .HasColumnName("libegouv");
                entity.Property(e => e.Libeinterv)
                    .HasMaxLength(250)
                    .HasColumnName("libeinterv");
            });

            modelBuilder.Entity<ViewInventaireEtablissement>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Inventaire_Etablissement");

                entity.Property(e => e.AdreEtab).HasMaxLength(100);
                entity.Property(e => e.AdrePersFond).HasMaxLength(250);
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeDipl).HasMaxLength(50);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGenr).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeNiveEtud).HasMaxLength(50);
                entity.Property(e => e.CodePost).HasMaxLength(50);
                entity.Property(e => e.CodePostFond).HasMaxLength(50);
                entity.Property(e => e.CodeSect).HasMaxLength(50);
                entity.Property(e => e.CodeSituFami).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeZone).HasMaxLength(50);
                entity.Property(e => e.DateCrea).HasColumnType("datetime");
                entity.Property(e => e.DateDeciOuve).HasColumnType("datetime");
                entity.Property(e => e.DateDeliv).HasColumnType("datetime");
                entity.Property(e => e.DateDemaActi).HasColumnType("datetime");
                entity.Property(e => e.DateDepoCahiChar).HasColumnType("datetime");
                entity.Property(e => e.DateNaisFond).HasColumnType("datetime");
                entity.Property(e => e.Email).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDipl).HasMaxLength(500);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeGenr).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeNiveEtud).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeSituFami).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
                entity.Property(e => e.LieuNaisFond).HasMaxLength(50);
                entity.Property(e => e.MatrFisc).HasMaxLength(50);
                entity.Property(e => e.NomPrenFond).HasMaxLength(50);
                entity.Property(e => e.NumeDeciOuve).HasMaxLength(50);
                entity.Property(e => e.NumePiecIden).HasMaxLength(50);
                entity.Property(e => e.Prof).HasMaxLength(250);
                entity.Property(e => e.Tele).HasMaxLength(13);
            });

            modelBuilder.Entity<ViewMessageDetail>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Message_detail");

                entity.Property(e => e.CodeTypeM).HasMaxLength(50);
                entity.Property(e => e.CodeUtilFrom).HasMaxLength(50);
                entity.Property(e => e.Codeutil)
                    .HasMaxLength(50)
                    .HasColumnName("codeutil");
                entity.Property(e => e.DateEnvoi).HasColumnType("datetime");
                entity.Property(e => e.Datereception).HasColumnType("datetime");
                entity.Property(e => e.IdMessage).HasColumnName("idMessage");
                entity.Property(e => e.IdmessageParent).HasColumnName("Idmessage_Parent");
                entity.Property(e => e.LibeTypeM).HasMaxLength(250);
                entity.Property(e => e.Lu).HasColumnName("lu");
                entity.Property(e => e.Mail).HasColumnName("mail");
                entity.Property(e => e.NomPrenUtil).HasMaxLength(100);
                entity.Property(e => e.Text).HasColumnName("text");
                entity.Property(e => e.Titre).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewNomenclatureCategorieRubriqueInspection>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Nomenclature_CategorieRubriqueInspection");

                entity.Property(e => e.CodeCateRubrInsp).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeCateRubrInsp).HasMaxLength(305);
            });

            modelBuilder.Entity<ViewNomenclatureCommune>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Nomenclature_Commune");

                entity.Property(e => e.CodeComm).HasMaxLength(50);
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewNomenclatureDelegation>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Nomenclature_Delegation");

                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewNomenclatureDelegation2>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Nomenclature_Delegation2");

                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeDele).HasMaxLength(104);
            });

            modelBuilder.Entity<ViewNomenclatureEquipement>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Nomenclature_Equipement");

                entity.Property(e => e.CaraEqui)
                    .UseCollation("Arabic_CI_AS")
                    .HasColumnType("text");
                entity.Property(e => e.CodeEqui).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEqui).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEqui).HasMaxLength(1000);
            });

            modelBuilder.Entity<ViewNomenclatureGouvernorat>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Nomenclature_Gouvernorat");

                entity.Property(e => e.CodeDist).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewNomenclatureRubriqueInspection>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Nomenclature_RubriqueInspection");

                entity.Property(e => e.CodeCateRubrInsp).HasMaxLength(50);
                entity.Property(e => e.CodeRubrInsp).HasMaxLength(50);
                entity.Property(e => e.LibeCateRubrInsp).HasMaxLength(250);
                entity.Property(e => e.LibeRubrInsp).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewNomenclatureRubriqueInspection2>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Nomenclature_RubriqueInspection2");

                entity.Property(e => e.CodeCateRubrInsp).HasMaxLength(50);
                entity.Property(e => e.CodeRubrInsp).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeRubrInsp).HasMaxLength(556);
            });

            modelBuilder.Entity<ViewPassation>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_passation");

                entity.Property(e => e.Adirecteur).HasColumnName("ADirecteur");
                entity.Property(e => e.CodePas).HasColumnName("codePas");
                entity.Property(e => e.Codegouv).HasMaxLength(50);
                entity.Property(e => e.Codeutil).HasMaxLength(50);
                entity.Property(e => e.CodeutilM).HasMaxLength(50);
                entity.Property(e => e.Codeutilrapport)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilrapport");
                entity.Property(e => e.DatePas).HasColumnType("date");
                entity.Property(e => e.Datecreation).HasColumnType("datetime");
                entity.Property(e => e.Datemodification).HasColumnType("datetime");
                entity.Property(e => e.Daterapport)
                    .HasColumnType("datetime")
                    .HasColumnName("daterapport");
                entity.Property(e => e.Libegouv)
                    .HasMaxLength(50)
                    .HasColumnName("libegouv");
                entity.Property(e => e.Moispassation)
                    .HasMaxLength(61)
                    .HasColumnName("moispassation");
                entity.Property(e => e.Participant).HasMaxLength(500);
                entity.Property(e => e.Refrence).HasColumnName("refrence");
            });

            modelBuilder.Entity<ViewProposition>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_proposition");

                entity.Property(e => e.CodePro).HasColumnName("codePro");
                entity.Property(e => e.CodeTypePro).HasMaxLength(50);
                entity.Property(e => e.Codegouv).HasMaxLength(50);
                entity.Property(e => e.Codeutil).HasMaxLength(50);
                entity.Property(e => e.CodeutilM).HasMaxLength(50);
                entity.Property(e => e.DatePro).HasColumnType("date");
                entity.Property(e => e.Datecreation).HasColumnType("datetime");
                entity.Property(e => e.Datemodification).HasColumnType("datetime");
                entity.Property(e => e.LibeNatPro).HasMaxLength(250);
                entity.Property(e => e.Libegouv)
                    .HasMaxLength(50)
                    .HasColumnName("libegouv");
                entity.Property(e => e.LibetypePro).HasMaxLength(250);
                entity.Property(e => e.Moisproposition)
                    .HasMaxLength(61)
                    .HasColumnName("moisproposition");
                entity.Property(e => e.Nomprenutil)
                    .HasMaxLength(100)
                    .HasColumnName("nomprenutil");
            });

            modelBuilder.Entity<ViewRapportActivite>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Rapport_Activite");

                entity.Property(e => e.CodeAct).HasColumnName("codeAct");
                entity.Property(e => e.CodeNatAct).HasMaxLength(50);
                entity.Property(e => e.CodeSecFor).HasMaxLength(50);
                entity.Property(e => e.Codegouv).HasMaxLength(50);
                entity.Property(e => e.Codeutil).HasMaxLength(50);
                entity.Property(e => e.CodeutilM).HasMaxLength(50);
                entity.Property(e => e.Codeutilrapport)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilrapport");
                entity.Property(e => e.DateAct).HasColumnType("date");
                entity.Property(e => e.Datecreation).HasColumnType("datetime");
                entity.Property(e => e.Datemodification).HasColumnType("datetime");
                entity.Property(e => e.Daterapport)
                    .HasColumnType("datetime")
                    .HasColumnName("daterapport");
                entity.Property(e => e.LibeGouv)
                    .HasMaxLength(50)
                    .HasColumnName("libeGouv");
                entity.Property(e => e.LibeNatAct).HasMaxLength(250);
                entity.Property(e => e.LibesecFor).HasMaxLength(250);
                entity.Property(e => e.Participant).HasMaxLength(500);
                entity.Property(e => e.Typepart).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRapportEvent>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_Rapport_Event");

                entity.Property(e => e.CodeEvent).HasColumnName("codeEvent");
                entity.Property(e => e.CodeNivFor).HasMaxLength(50);
                entity.Property(e => e.CodeSecFor).HasMaxLength(50);
                entity.Property(e => e.Codegouv).HasMaxLength(50);
                entity.Property(e => e.Codeutil).HasMaxLength(50);
                entity.Property(e => e.CodeutilM).HasMaxLength(50);
                entity.Property(e => e.Codeutilrapport)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilrapport");
                entity.Property(e => e.DateEvent).HasColumnType("date");
                entity.Property(e => e.Datecreation).HasColumnType("datetime");
                entity.Property(e => e.Datemodification).HasColumnType("datetime");
                entity.Property(e => e.Daterapport)
                    .HasColumnType("datetime")
                    .HasColumnName("daterapport");
                entity.Property(e => e.InvesEvent).HasMaxLength(50);
                entity.Property(e => e.LibeGouv)
                    .HasMaxLength(50)
                    .HasColumnName("libeGouv");
                entity.Property(e => e.LibeNatInv).HasMaxLength(250);
                entity.Property(e => e.LibeNivFor).HasMaxLength(250);
                entity.Property(e => e.LibesecFor).HasMaxLength(250);
                entity.Property(e => e.NomEvent).HasMaxLength(50);
                entity.Property(e => e.Participant).HasMaxLength(500);
                entity.Property(e => e.PrixEvent).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRapportPassation>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("view_rapport_Passation");

                entity.Property(e => e.Adirecteur).HasColumnName("ADirecteur");
                entity.Property(e => e.Arefrence).HasMaxLength(50);
                entity.Property(e => e.CodePas).HasColumnName("codePas");
                entity.Property(e => e.Codegouv).HasMaxLength(50);
                entity.Property(e => e.Codeutil).HasMaxLength(50);
                entity.Property(e => e.CodeutilM).HasMaxLength(50);
                entity.Property(e => e.Codeutilrapport)
                    .HasMaxLength(50)
                    .HasColumnName("codeutilrapport");
                entity.Property(e => e.DatePas).HasColumnType("date");
                entity.Property(e => e.Datecreation).HasColumnType("datetime");
                entity.Property(e => e.Datemodification).HasColumnType("datetime");
                entity.Property(e => e.Daterapport)
                    .HasColumnType("datetime")
                    .HasColumnName("daterapport");
                entity.Property(e => e.LibeGouv)
                    .HasMaxLength(50)
                    .HasColumnName("libeGouv");
                entity.Property(e => e.Participant).HasMaxLength(500);
                entity.Property(e => e.Refrence)
                    .HasMaxLength(50)
                    .HasColumnName("refrence");
            });

            modelBuilder.Entity<ViewRepartitionClub>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionClub");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.Codeetab1)
                    .HasMaxLength(50)
                    .HasColumnName("codeetab1");
                entity.Property(e => e.LibeClub).HasMaxLength(250);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
                entity.Property(e => e.Nbseance).HasColumnName("nbseance");
                entity.Property(e => e.PrixClub).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionClubgeneral>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionClubgeneral");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeEtab1).HasMaxLength(81);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
                entity.Property(e => e.PrixClub).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleve>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleve");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.Couverture).HasColumnName("couverture");
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveEtatParent>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveEtatParents");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeEtatPare).HasMaxLength(250);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveEtatPsycologique>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveEtatPsycologique");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeEtatPsyc).HasMaxLength(250);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveEtatSante>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveEtatSante");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeEtatSant).HasMaxLength(250);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveGroupeTrancheAge>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveGroupeTrancheAge");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTranAge).HasMaxLength(250);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveHandicap>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveHandicap");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.DateNais).HasColumnType("date");
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDegrHand).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGenr).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeInteHand).HasMaxLength(250);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeTypeHand).HasMaxLength(250);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveHandicapListe>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveHandicap_liste");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.DateNais).HasColumnType("date");
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDegrHand).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeGenr).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeInteHand).HasMaxLength(250);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeHand).HasMaxLength(250);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
                entity.Property(e => e.NomPren).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewRepartitionEleveLangueMaternelle>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveLangueMaternelle");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeLangMate).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveNationalite>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveNationalite");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeNati).HasMaxLength(250);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveNiveauEtudeMere>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveNiveauEtudeMere");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeNiveEtud).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveNiveauEtudePere>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveNiveauEtudePere");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeNiveEtud).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveNiveauSalaireParent>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveNiveauSalaireParents");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeNiveSala).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionElevePriseCharge>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionElevePriseCharge");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeTypePrisChar).HasMaxLength(50);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveProfessionMere>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveProfessionMere");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeProf).HasMaxLength(250);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveProfessionPere>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveProfessionPere");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeProf).HasMaxLength(250);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveTrancheAge>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveTrancheAge");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.Couverture).HasColumnName("couverture");
                entity.Property(e => e.DepoCahiCharPrep).HasMaxLength(3);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTranAge).HasMaxLength(250);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveTrancheAgeArretEtude>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveTrancheAgeArretEtude");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTranAge).HasMaxLength(250);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveTrancheAgeBeneficaire>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveTrancheAgeBeneficaire");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTranAge).HasMaxLength(250);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveTrancheAgeTypePrisChar>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveTrancheAgeTypePrisChar");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTranAge).HasMaxLength(250);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeTypePrisChar).HasMaxLength(50);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEleveTypeInscription>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEleveTypeInscription");

                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeTypeInsc).HasMaxLength(1000);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionEnfantNe>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionEnfantNE");

                entity.Property(e => e.AdrePers).HasMaxLength(250);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodePost).HasMaxLength(50);
                entity.Property(e => e.DateNais).HasColumnType("date");
                entity.Property(e => e.Datearret)
                    .HasColumnType("date")
                    .HasColumnName("datearret");
                entity.Property(e => e.Dateinscrit)
                    .HasColumnType("date")
                    .HasColumnName("dateinscrit");
                entity.Property(e => e.EtatEnfant).HasMaxLength(5);
                entity.Property(e => e.Idenfant).HasColumnName("idenfant");
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeEtatFam).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeNaturePere).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
                entity.Property(e => e.Libegenr)
                    .HasMaxLength(50)
                    .HasColumnName("libegenr");
                entity.Property(e => e.LieuNais).HasMaxLength(50);
                entity.Property(e => e.Motifarret)
                    .HasMaxLength(50)
                    .HasColumnName("motifarret");
                entity.Property(e => e.Nompere)
                    .HasMaxLength(50)
                    .HasColumnName("nompere");
                entity.Property(e => e.Nomprenom)
                    .HasMaxLength(50)
                    .HasColumnName("nomprenom");
                entity.Property(e => e.NumTel).HasMaxLength(50);
                entity.Property(e => e.NumeCin)
                    .HasMaxLength(10)
                    .HasColumnName("NumeCIN");
                entity.Property(e => e.Profession).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRepartitionSignalisation>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RepartitionSignalisation");

                entity.Property(e => e.Acti).HasColumnName("acti");
                entity.Property(e => e.AdresseConcerne).HasMaxLength(50);
                entity.Property(e => e.Anomalie).HasMaxLength(500);
                entity.Property(e => e.ChefService).HasMaxLength(50);
                entity.Property(e => e.CodeConcerne).HasMaxLength(50);
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeInformateur).HasMaxLength(50);
                entity.Property(e => e.CodeInspecteur).HasMaxLength(50);
                entity.Property(e => e.CodeResponsable).HasMaxLength(50);
                entity.Property(e => e.CodeStatus).HasMaxLength(50);
                entity.Property(e => e.CodeTypeSignalisation).HasMaxLength(50);
                entity.Property(e => e.ConusltatEnfance).HasColumnName("conusltatEnfance");
                entity.Property(e => e.DateAnalyse).HasColumnType("date");
                entity.Property(e => e.DateChefService).HasColumnType("date");
                entity.Property(e => e.DateCloture).HasColumnType("date");
                entity.Property(e => e.DateCreation).HasColumnType("date");
                entity.Property(e => e.DateDepot).HasColumnType("date");
                entity.Property(e => e.DateInfoInspecteur).HasColumnType("date");
                entity.Property(e => e.DateSignalisation).HasMaxLength(61);
                entity.Property(e => e.Datecreationrapport)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreationrapport");
                entity.Property(e => e.Datevisite)
                    .HasColumnType("date")
                    .HasColumnName("datevisite");
                entity.Property(e => e.Email).HasMaxLength(50);
                entity.Property(e => e.Enfance).HasMaxLength(3);
                entity.Property(e => e.Etablissement).HasMaxLength(50);
                entity.Property(e => e.Fichier).HasColumnName("fichier");
                entity.Property(e => e.Inspecteur2).HasMaxLength(50);
                entity.Property(e => e.LibeConcerne).HasMaxLength(50);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtatSignalisation)
                    .HasMaxLength(50)
                    .HasColumnName("libeEtatSignalisation");
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeInformateur).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.Methode).HasMaxLength(50);
                entity.Property(e => e.MethodeSignalisation).HasMaxLength(50);
                entity.Property(e => e.MoisSignalisation).HasMaxLength(30);
                entity.Property(e => e.MotifSupression).HasMaxLength(255);
                entity.Property(e => e.NomConcerne).HasMaxLength(50);
                entity.Property(e => e.NomInformateur).HasMaxLength(50);
                entity.Property(e => e.NumeroDepot).HasMaxLength(50);
                entity.Property(e => e.Numrapport)
                    .HasMaxLength(1)
                    .IsUnicode(false);
                entity.Property(e => e.Responsable).HasMaxLength(100);
                entity.Property(e => e.ResponsableSignalisation).HasMaxLength(100);
                entity.Property(e => e.Tel).HasMaxLength(50);
                entity.Property(e => e.TypeEtablissement).HasMaxLength(50);
                entity.Property(e => e.TypeSign).HasMaxLength(50);
                entity.Property(e => e.TypeSignalisation).HasMaxLength(50);
                entity.Property(e => e.Ville).HasMaxLength(50);
                entity.Property(e => e.VilleConcerne).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewRessourceHumain>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_RessourceHumain");

                entity.Property(e => e.AdrePers).HasMaxLength(250);
                entity.Property(e => e.Cadreinspection).HasMaxLength(500);
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.DateCin)
                    .HasColumnType("datetime")
                    .HasColumnName("DateCIN");
                entity.Property(e => e.Dateaffectation)
                    .HasColumnType("date")
                    .HasColumnName("dateaffectation");
                entity.Property(e => e.DatenotePead)
                    .HasColumnType("date")
                    .HasColumnName("datenotePead");
                entity.Property(e => e.Daterecrutement)
                    .HasColumnType("date")
                    .HasColumnName("daterecrutement");
                entity.Property(e => e.Daterespons)
                    .HasColumnType("date")
                    .HasColumnName("daterespons");
                entity.Property(e => e.Email).HasMaxLength(50);
                entity.Property(e => e.HasIdenUniqMatrCnss)
                    .HasMaxLength(21)
                    .HasColumnName("hasIdenUniqMatrCnss");
                entity.Property(e => e.IdenUniqMatrCnss).HasMaxLength(50);
                entity.Property(e => e.LibeCommEtab).HasMaxLength(250);
                entity.Property(e => e.LibeCorp).HasMaxLength(50);
                entity.Property(e => e.LibeDeleEtab).HasMaxLength(50);
                entity.Property(e => e.LibeDelePers).HasMaxLength(50);
                entity.Property(e => e.LibeDipl).HasMaxLength(500);
                entity.Property(e => e.LibeDistEtab).HasMaxLength(50);
                entity.Property(e => e.LibeDistPers).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeFonc).HasMaxLength(50);
                entity.Property(e => e.LibeGenr).HasMaxLength(50);
                entity.Property(e => e.LibeGouvEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGouvPers).HasMaxLength(50);
                entity.Property(e => e.LibeGrad).HasMaxLength(250);
                entity.Property(e => e.LibeNiveEtud).HasMaxLength(50);
                entity.Property(e => e.LibeQual).HasMaxLength(50);
                entity.Property(e => e.LibeReveMens).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeSituFami).HasMaxLength(50);
                entity.Property(e => e.LibeSituProf).HasMaxLength(50);
                entity.Property(e => e.LibeStruAtta)
                    .HasMaxLength(1000)
                    .HasColumnName("libeStruAtta");
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
                entity.Property(e => e.MoisAff).HasMaxLength(30);
                entity.Property(e => e.MoisRec).HasMaxLength(30);
                entity.Property(e => e.MoisRes).HasMaxLength(30);
                entity.Property(e => e.NomPren).HasMaxLength(250);
                entity.Property(e => e.NotePead)
                    .HasMaxLength(50)
                    .HasColumnName("notePead");
                entity.Property(e => e.NumeCin)
                    .HasMaxLength(10)
                    .HasColumnName("NumeCIN");
                entity.Property(e => e.TelGsm)
                    .HasMaxLength(50)
                    .HasColumnName("TelGSM");
            });

            modelBuilder.Entity<ViewSignalisation>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Signalisation");

                entity.Property(e => e.Acti).HasColumnName("acti");
                entity.Property(e => e.AdresseConcerne).HasMaxLength(50);
                entity.Property(e => e.ChefService).HasMaxLength(50);
                entity.Property(e => e.CodeConcerne).HasMaxLength(50);
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeInformateur).HasMaxLength(50);
                entity.Property(e => e.CodeInspecteur).HasMaxLength(50);
                entity.Property(e => e.CodeResponsable).HasMaxLength(50);
                entity.Property(e => e.CodeStatus).HasMaxLength(50);
                entity.Property(e => e.CodeTypeSignalisation).HasMaxLength(50);
                entity.Property(e => e.ConusltatEnfance).HasColumnName("conusltatEnfance");
                entity.Property(e => e.DateAnalyse).HasColumnType("date");
                entity.Property(e => e.DateChefService).HasColumnType("date");
                entity.Property(e => e.DateCloture).HasColumnType("date");
                entity.Property(e => e.DateCreation).HasColumnType("date");
                entity.Property(e => e.DateDepot).HasColumnType("date");
                entity.Property(e => e.DateInfoInspecteur).HasColumnType("date");
                entity.Property(e => e.DateSignalisation).HasColumnType("date");
                entity.Property(e => e.Datecreationrapport)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreationrapport");
                entity.Property(e => e.Datevisite)
                    .HasColumnType("date")
                    .HasColumnName("datevisite");
                entity.Property(e => e.Email).HasMaxLength(50);
                entity.Property(e => e.Etablissement).HasMaxLength(50);
                entity.Property(e => e.Fichier).HasColumnName("fichier");
                entity.Property(e => e.Inspecteur2).HasMaxLength(50);
                entity.Property(e => e.LibeConcerne).HasMaxLength(50);
                entity.Property(e => e.LibeInformateur).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.Methode).HasMaxLength(50);
                entity.Property(e => e.MethodeSignalisation).HasMaxLength(50);
                entity.Property(e => e.MotifSupression).HasMaxLength(255);
                entity.Property(e => e.NomConcerne).HasMaxLength(50);
                entity.Property(e => e.NomInformateur).HasMaxLength(50);
                entity.Property(e => e.NumeroDepot).HasMaxLength(50);
                entity.Property(e => e.Numrapport)
                    .HasMaxLength(1)
                    .IsUnicode(false);
                entity.Property(e => e.Responsable).HasMaxLength(100);
                entity.Property(e => e.Tel).HasMaxLength(50);
                entity.Property(e => e.TypeEtablissement).HasMaxLength(50);
                entity.Property(e => e.TypeSign).HasMaxLength(50);
                entity.Property(e => e.TypeSignalisation).HasMaxLength(50);
                entity.Property(e => e.Ville).HasMaxLength(50);
                entity.Property(e => e.VilleConcerne).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewTraceUtilisateur>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_TraceUtilisateur");

                entity.Property(e => e.Codeenti)
                    .HasMaxLength(100)
                    .HasColumnName("CODEENTI");
                entity.Property(e => e.Codetypeoper)
                    .HasMaxLength(100)
                    .HasColumnName("CODETYPEOPER");
                entity.Property(e => e.Codeutil)
                    .HasMaxLength(100)
                    .HasColumnName("CODEUTIL");
                entity.Property(e => e.Datetrac)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETRAC");
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.Libeenti)
                    .HasMaxLength(500)
                    .HasColumnName("LIBEENTI");
                entity.Property(e => e.Libepack)
                    .HasMaxLength(100)
                    .HasColumnName("LIBEPACK");
                entity.Property(e => e.Libetrac)
                    .HasMaxLength(1000)
                    .HasColumnName("LIBETRAC");
                entity.Property(e => e.Linktrac)
                    .HasMaxLength(300)
                    .HasColumnName("LINKTRAC");
                entity.Property(e => e.Nomprenutil)
                    .HasMaxLength(100)
                    .HasColumnName("NOMPRENUTIL");
                entity.Property(e => e.Numetrac)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("NUMETRAC");
                entity.Property(e => e.Pkenti)
                    .HasMaxLength(200)
                    .HasColumnName("PKENTI");
            });

            modelBuilder.Entity<ViewTraceUtilisateur1>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_TraceUtilisateurs");

                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.Datetrac)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETRAC");
                entity.Property(e => e.JourSemaTrac).HasMaxLength(63);
                entity.Property(e => e.JourTrac)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.Libeenti)
                    .HasMaxLength(500)
                    .HasColumnName("LIBEENTI");
                entity.Property(e => e.Libegrouutil)
                    .HasMaxLength(510)
                    .HasColumnName("LIBEGROUUTIL");
                entity.Property(e => e.Libepack)
                    .HasMaxLength(100)
                    .HasColumnName("LIBEPACK");
                entity.Property(e => e.Libetrac)
                    .HasMaxLength(1000)
                    .HasColumnName("LIBETRAC");
                entity.Property(e => e.Libetypeopertrac)
                    .HasMaxLength(500)
                    .HasColumnName("LIBETYPEOPERTRAC");
                entity.Property(e => e.Matr)
                    .HasMaxLength(100)
                    .HasColumnName("MATR");
                entity.Property(e => e.MoisTrac).HasMaxLength(4000);
                entity.Property(e => e.Nomprenutil)
                    .HasMaxLength(100)
                    .HasColumnName("NOMPRENUTIL");
                entity.Property(e => e.Numetrac)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("NUMETRAC");
                entity.Property(e => e.QuarTrac)
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewUtilisateur>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_Utilisateur");

                entity.Property(e => e.CodeCommFonc).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodeUtilPare).HasMaxLength(100);
                entity.Property(e => e.Codegrouutil)
                    .HasMaxLength(100)
                    .HasColumnName("CODEGROUUTIL");
                entity.Property(e => e.Codenivehier)
                    .HasMaxLength(100)
                    .HasColumnName("CODENIVEHIER");
                entity.Property(e => e.Codeutil)
                    .HasMaxLength(100)
                    .HasColumnName("CODEUTIL");
                entity.Property(e => e.Datemaj)
                    .HasColumnType("datetime")
                    .HasColumnName("DATEMAJ");
                entity.Property(e => e.Email).HasMaxLength(250);
                entity.Property(e => e.Gsm)
                    .HasMaxLength(50)
                    .HasColumnName("GSM");
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.Libegrouutil)
                    .HasMaxLength(510)
                    .HasColumnName("LIBEGROUUTIL");
                entity.Property(e => e.Matr)
                    .HasMaxLength(100)
                    .HasColumnName("MATR");
                entity.Property(e => e.Motpassutil).HasColumnName("MOTPASSUTIL");
                entity.Property(e => e.Nomprenutil)
                    .HasMaxLength(100)
                    .HasColumnName("NOMPRENUTIL");
                entity.Property(e => e.SkypeId)
                    .HasMaxLength(50)
                    .HasColumnName("SkypeID");
                entity.Property(e => e.Tele).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewVeetablissement>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("View_VEEtablissement");

                entity.Property(e => e.AdreEtab).HasMaxLength(100);
                entity.Property(e => e.CausFerm).HasMaxLength(500);
                entity.Property(e => e.CodeDele).HasMaxLength(50);
                entity.Property(e => e.CodeEtab).HasMaxLength(50);
                entity.Property(e => e.CodeGouv).HasMaxLength(50);
                entity.Property(e => e.CodePost).HasMaxLength(50);
                entity.Property(e => e.CodePostEtab).HasMaxLength(50);
                entity.Property(e => e.CodeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.DateDemaActi).HasColumnType("datetime");
                entity.Property(e => e.DateFerm).HasColumnType("datetime");
                entity.Property(e => e.LibeComm).HasMaxLength(250);
                entity.Property(e => e.LibeCommEtab).HasMaxLength(250);
                entity.Property(e => e.LibeDele).HasMaxLength(50);
                entity.Property(e => e.LibeDiplFond).HasMaxLength(500);
                entity.Property(e => e.LibeDist).HasMaxLength(50);
                entity.Property(e => e.LibeEtab).HasMaxLength(250);
                entity.Property(e => e.LibeEtatEtab).HasMaxLength(50);
                entity.Property(e => e.LibeGenrFond).HasMaxLength(50);
                entity.Property(e => e.LibeGouv).HasMaxLength(50);
                entity.Property(e => e.LibeNiveEtudFond).HasMaxLength(50);
                entity.Property(e => e.LibeOuveEtab).HasMaxLength(50);
                entity.Property(e => e.LibeSect).HasMaxLength(50);
                entity.Property(e => e.LibeSituFamiFond).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtab).HasMaxLength(50);
                entity.Property(e => e.LibeTypeEtatEtab).HasMaxLength(6);
                entity.Property(e => e.LibeZone).HasMaxLength(50);
                entity.Property(e => e.LieuNaisFond).HasMaxLength(50);
                entity.Property(e => e.MoisDeciOuvr).HasMaxLength(30);
                entity.Property(e => e.MoisFerm).HasMaxLength(30);
                entity.Property(e => e.NomPrenFond).HasMaxLength(50);
                entity.Property(e => e.NumePiecIden).HasMaxLength(50);
                entity.Property(e => e.QuarFerm)
                    .HasMaxLength(14)
                    .IsUnicode(false);
                entity.Property(e => e.Tele).HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
