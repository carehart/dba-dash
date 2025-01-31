﻿CREATE TYPE dbo.Backups AS TABLE (
    database_name sysname     NOT NULL,
    type          CHAR (1)      NULL,
    backup_start_date DATETIME NOT NULL,
    backup_finish_date DATETIME NULL,
    backup_set_id INT NULL,
    time_zone SMALLINT NULL,
    backup_size DECIMAL(20, 0) NULL,
    is_password_protected BIT NULL,
    recovery_model NVARCHAR(60) NULL,
    has_bulk_logged_data BIT NULL,
    is_snapshot BIT NULL,
    is_readonly BIT NULL,
    is_single_user BIT NULL,
    has_backup_checksums BIT NULL,
    is_damaged BIT NULL,
    has_incomplete_metadata BIT NULL,
    is_force_offline BIT NULL,
    is_copy_only BIT NULL,
    database_guid UNIQUEIDENTIFIER NULL,
    family_guid UNIQUEIDENTIFIER NULL,
    compressed_backup_size DECIMAL(20, 0) NULL,
    key_algorithm NVARCHAR(32) NULL,
    encryptor_type NVARCHAR(32) NULL
)

