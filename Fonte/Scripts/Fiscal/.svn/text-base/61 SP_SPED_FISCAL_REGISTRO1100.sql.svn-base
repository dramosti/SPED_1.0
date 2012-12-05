CREATE PROCEDURE SP_SPED_FISCAL_REGISTRO1100 (
    CD_EMPRESA VARCHAR(3),
    DT_EMI_INICIAL DATE,
    DT_EMI_FINAL DATE)
RETURNS (
    IND_DOC VARCHAR(1),
    NRO_DE VARCHAR(11),
    DT_DE DATE,
    NAT_EXP VARCHAR(1),
    NRO_RE VARCHAR(12),
    DT_RE DATE,
    CHC_EMB VARCHAR(18),
    DT_CHC DATE,
    DT_AVB DATE,
    TP_CHC VARCHAR(2),
    PAIS VARCHAR(3)
)
AS
BEGIN

    FOR SELECT
        '0' AS IND_DOC,
        '000001' AS NRO_DE,
        :DT_EMI_INICIAL AS DT_DE,
        '0' AS NAT_EXP,
        '10000001' AS NRO_RE,
        :DT_EMI_INICIAL AS DT_RE,
        '123' AS CHC_EMB,
        :DT_EMI_INICIAL AS DT_CHC,
        :DT_EMI_INICIAL AS DT_AVB,
        '01' AS TP_CHC,
        '1' AS PAIS
        FROM RDB$DATABASE
        UNION
        SELECT
        '1' AS IND_DOC,
        '000002' AS NRO_DE,
        :DT_EMI_FINAL AS DT_DE,
        '1' AS NAT_EXP,
        '10000002' AS NRO_RE,
        :DT_EMI_FINAL AS DT_RE,
        '456' AS CHC_EMB,
        :DT_EMI_FINAL AS DT_CHC,
        :DT_EMI_FINAL AS DT_AVB,
        '02' AS TP_CHC,
        '2' AS PAIS
        FROM RDB$DATABASE
    INTO
        :IND_DOC,
        :NRO_DE,
        :DT_DE,
        :NAT_EXP,
        :NRO_RE,
        :DT_RE,
        :CHC_EMB,
        :DT_CHC,
        :DT_AVB,
        :TP_CHC,
        :PAIS
    DO
    BEGIN
        SUSPEND;

    END

END
