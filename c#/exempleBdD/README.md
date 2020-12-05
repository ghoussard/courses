# Répertoire

> Création de la table "contact"

```sql
	CREATE TABLE [dbo].[contact] (
        [Id]        INT          IDENTITY (1, 1) NOT NULL,
        [nom]       VARCHAR (20) NOT NULL,
        [prénom]    VARCHAR (20) NULL,
        [téléphone] VARCHAR (20) NULL,
        PRIMARY KEY CLUSTERED ([Id] ASC)
    );
```