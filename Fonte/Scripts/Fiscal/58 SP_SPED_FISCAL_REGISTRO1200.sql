CREATE PROCEDURE SP_SPED_FISCAL_REGISTRO1200 (
    CD_EMPRESA VARCHAR(3),
    DT_EMI_INICIAL DATE,
    DT_EMI_FINAL DATE)
RETURNS (
    COD_AJ_APUR VARCHAR(8),
    SLD_CRED NUMERIC(15,2),
    CRED_APR NUMERIC(15,2),
    CRED_RECEB NUMERIC(15,2),
    CRED_UTIL NUMERIC(15,2),
    SLD_CRED_FIM NUMERIC(15,2)
)
AS
BEGIN

    FOR
    SELECT
        '00000001' AS COD_AJ_APUR,
        0.01 AS SLD_CRED,
        0.02 AS CRED_APR,
        0.03 AS CRED_RECEB,
        0.04 AS CRED_UTIL,
        0.05 AS SLD_CRED_FIM
    FROM RDB$DATABASE
    UNION
    SELECT
        '00000002' AS COD_AJ_APUR,
        1.01 AS SLD_CRED,
        1.02 AS CRED_APR,
        1.03 AS CRED_RECEB,
        1.04 AS CRED_UTIL,
        1.05 AS SLD_CRED_FIM
    FROM RDB$DATABASE
    INTO
        :COD_AJ_APUR,
        :SLD_CRED,
        :CRED_APR,
        :CRED_RECEB,
        :CRED_UTIL,
        :SLD_CRED_FIM
    DO
    BEGIN
        SUSPEND;
    END

END
