# R�pertoire

> Cr�ation de la table "contact"

```sql
	CREATE TABLE [dbo].[contact] (
        [Id]        INT          IDENTITY (1, 1) NOT NULL,
        [nom]       VARCHAR (20) NOT NULL,
        [pr�nom]    VARCHAR (20) NULL,
        [t�l�phone] VARCHAR (20) NULL,
        PRIMARY KEY CLUSTERED ([Id] ASC)
    );
```