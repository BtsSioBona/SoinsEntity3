-- CONSIGNES DROP --

DROP TABLE PRESTATION;
DROP TABLE INTERVENANT;
DROP TABLE INTERVENANTEXTERNE;
DROP TABLE DOSSIER;

-- CREATION --
CREATE TABLE "Prestation" (
  "Id" INTEGER NOT NULL PRIMARY KEY,
  "Nom" VARCHAR(30)NOT NULL,
  "DatePrestation" DATE NOT NULL,
  "Iddossier" INTEGER NOT NULL,
  "Idintervenant" INTEGER NOT NULL
);

CREATE TABLE "Intervenant" (
  "Id" INTEGER NOT NULL PRIMARY KEY,
  "Nom" VARCHAR(30)NOT NULL,
  "Prenom"  VARCHAR(30) NOT NULL
);

CREATE TABLE "IntervenantExterne"(
  "Id" INTEGER NOT NULL PRIMARY KEY,
  "Specialite" VARCHAR(30)NOT NULL,
  "Adresse" VARCHAR(50) NOT NULL,
  "Tel" VARCHAR(14) NOT NULL
);

CREATE TABLE "Dossier"(
  "Id" INTEGER NOT NULL PRIMARY KEY,
  "Nom" VARCHAR(30) NOT NULL,
  "Prenom" VARCHAR(30) NOT NULL,
  "DATEnaissance" DATE NOT NULL
);


--------------------------------------------------------
--  Fichier MODIFIE cr�� - lundi-octobre-03-2016   
--------------------------------------------------------
REM INSERTING into PRESTATION
SET DEFINE OFF;
Insert into PRESTATION (ID,NOM,DATEPRESTATION,IDDOSSIER,IDINTERVENANT) values ('1','Libelle Prestation 1',to_timestamp('10/09/15 12:15:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','1');
Insert into PRESTATION (ID,NOM,DATEPRESTATION,IDDOSSIER,IDINTERVENANT) values ('3','Libelle Prestation 3',to_timestamp('01/09/15 14:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','2');
Insert into PRESTATION (ID,NOM,DATEPRESTATION,IDDOSSIER,IDINTERVENANT) values ('15','Libelle Prestation 15',to_timestamp('01/09/15 16:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','3');
Insert into PRESTATION (ID,NOM,DATEPRESTATION,IDDOSSIER,IDINTERVENANT) values ('17','Libelle Prestation 17',to_timestamp('01/09/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','3');
REM INSERTING into INTERVENANTEXTERNE
SET DEFINE OFF;
Insert into INTERVENANTEXTERNE (ID,SPECIALITE,ADRESSE,TEL) values ('2','cardiologue','Boulevard de Starsbourg 83000 Toulon','04 94 94 94 94');
Insert into INTERVENANTEXTERNE (ID,SPECIALITE,ADRESSE,TEL) values ('3','radiologue','Avenue de la r�publique 83000 Toulon','04 94 90 90 90');
REM INSERTING into INTERVENANT
SET DEFINE OFF;
Insert into INTERVENANT (ID,NOM,PRENOM) values ('1','Dr Intervun','Jean');
Insert into INTERVENANT (ID,NOM,PRENOM) values ('2','Dr Intervdeux','Martine');
Insert into INTERVENANT (ID,NOM,PRENOM) values ('3','Dr Intervtrois','Michel');
REM INSERTING into DOSSIER
SET DEFINE OFF;
Insert into DOSSIER (ID,NOM,PRENOM,DATENAISSANCE) values ('1','Robert','Jean',to_date('03/12/80','DD/MM/RR'));
Insert into DOSSIER (ID,NOM,PRENOM,DATENAISSANCE) values ('2','Blanc','Sophie',to_date('14/02/95','DD/MM/RR'));


ALTER TABLE PRESTATION
ADD FOREIGN KEY (idintervenant)
REFERENCES INTERVENANT(id);

ALTER TABLE INTERVENANT
ADD FOREIGN KEY (id)
REFERENCES INTERVENANTEXTERNE(id);

