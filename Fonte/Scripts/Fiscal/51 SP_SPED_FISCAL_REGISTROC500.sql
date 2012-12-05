CREATE PROCEDURE SP_SPED_FISCAL_REGISTROC500 (
    CD_EMPRESA VARCHAR(3),
    DT_EMI_INICIAL DATE,
    DT_EMI_FINAL DATE)
RETURNS (
    PK_NOTAFIS VARCHAR(7),
    ST_DOC_CANCELADO VARCHAR(1),
    IND_OPER VARCHAR(1),
    IND_EMIT VARCHAR(1),
    COD_PART VARCHAR(60),
    COD_MOD VARCHAR(2),
    COD_SIT VARCHAR(2),
    SER VARCHAR(4),
    SUB VARCHAR(3),
    COD_CONS VARCHAR(2),
    NUM_DOC VARCHAR(20),
    DT_DOC DATE,
    DT_E_S DATE,
    VL_DOC NUMERIC(15,2),
    VL_DESC NUMERIC(15,2),
    VL_FORN NUMERIC(15,2),
    VL_SERV_NT NUMERIC(15,2),
    VL_TERC NUMERIC(15,2),
    VL_DA NUMERIC(15,2),
    VL_BC_ICMS NUMERIC(15,2),
    VL_ICMS NUMERIC(15,2),
    VL_BC_ICMS_ST NUMERIC(15,2),
    VL_ICMS_ST NUMERIC(15,2),
    COD_INF VARCHAR(6),
    VL_PIS NUMERIC(15,2),
    VL_COFINS NUMERIC(15,2),
    TP_LIGACAO VARCHAR(1),
    COD_GRUPO_TENSAO VARCHAR(2)
)
AS
BEGIN

    -- FILTRAR INFORMAÇÕES DA TABELA NOTALF COM BASE NOS PARÂMETROS
    -- FORNECIDOS ACIMA

    -- PK_NOTAFIS DEVERÁ RETORNAR O VALOR DO CAMPO NR_SEQNF DE NOTALF
    -- COD_PART: RETORNAR O CAMPO CD_CLIFOR DE NOTALF
    -- ST_DOC_CANCELADO: : RETORNAR O CAMPO ST_CANC DE NOTALF

    FOR SELECT
        '0000001' AS NR_SEQNF,
        'N' AS ST_DOC_CANCELADO,
        '1' AS IND_OPER,
        '0' AS IND_EMIT,
        '00' AS COD_MOD,
        '0000018' AS COD_PART,
        '00' AS COD_SIT,
        '0001' AS SER,
        '001' AS SUB,
        '01' AS COD_CONS,
        '000001' AS NUM_DOC,
        :DT_EMI_INICIAL AS DT_DOC,
        :DT_EMI_INICIAL AS DT_E_S,
        1001.01 AS VL_DOC,
        0.01 AS VL_DESC,
        0.02 AS VL_FORN,
        0.12 AS VL_SERV_NT,
        1.12 AS VL_TERC,
        11.12 AS VL_DA,
        0.05 AS VL_BC_ICMS,
        0.06 AS VL_ICMS,
        0.15 AS VL_BC_ICMS_ST,
        0.16 AS VL_ICMS_ST,
        NULL AS COD_INF,
        0.03 AS VL_PIS,
        0.13 AS VL_COFINS,
        '1' AS TP_LIGACAO,
        '01' AS COD_GRUPO_TENSAO
        FROM RDB$DATABASE
        UNION
        SELECT
        '0000002' AS NR_SEQNF,
        'S' AS ST_DOC_CANCELADO,
        '1' AS IND_OPER,
        '0' AS IND_EMIT,
        '11' AS COD_MOD,
        '0000019' AS COD_PART,
        '02' AS COD_SIT,
        '0001' AS SER,
        '001' AS SUB,
        '02' AS COD_CONS,
        '000002' AS NUM_DOC,
        :DT_EMI_INICIAL AS DT_DOC,
        :DT_EMI_INICIAL AS DT_E_S,
        20002.22 AS VL_DOC,
        1.01 AS VL_DESC,
        1.02 AS VL_FORN,
        1.12 AS VL_SERV_NT,
        11.12 AS VL_TERC,
        111.12 AS VL_DA,
        1.05 AS VL_BC_ICMS,
        1.06 AS VL_ICMS,
        1.15 AS VL_BC_ICMS_ST,
        1.16 AS VL_ICMS_ST,
        NULL AS COD_INF,
        1.03 AS VL_PIS,
        1.13 AS VL_COFINS,
        '2' AS TP_LIGACAO,
        '02' AS COD_GRUPO_TENSAO
        FROM RDB$DATABASE
        UNION
        SELECT
        '0000003' AS NR_SEQNF,
        'N' AS ST_DOC_CANCELADO,
        '1' AS IND_OPER,
        '0' AS IND_EMIT,
        '22' AS COD_MOD,
        '0000021' AS COD_PART,
        '00' AS COD_SIT,
        '0001' AS SER,
        '001' AS SUB,
        '03' AS COD_CONS,
        '000003' AS NUM_DOC,
        :DT_EMI_FINAL AS DT_DOC,
        :DT_EMI_FINAL AS DT_E_S,
        3003.03 VL_DOC,
        10.01 AS VL_DESC,
        10.02 AS VL_FORN,
        10.12 AS VL_SERV_NT,
        11.12 AS VL_TERC,
        111.12 AS VL_DA,
        10.05 AS VL_BC_ICMS,
        10.06 AS VL_ICMS,
        10.15 AS VL_BC_ICMS_ST,
        10.16 AS VL_ICMS_ST,
        NULL AS COD_INF,
        10.03 AS VL_PIS,
        10.13 AS VL_COFINS,
        '3' AS TP_LIGACAO,
        '03' AS COD_GRUPO_TENSAO
        FROM RDB$DATABASE
    INTO
        :PK_NOTAFIS,
        :ST_DOC_CANCELADO,
        :IND_OPER,
        :IND_EMIT,
        :COD_MOD,
        :COD_PART,
        :COD_SIT,
        :SER,
        :SUB,
        :COD_CONS,
        :NUM_DOC,
        :DT_DOC,
        :DT_E_S,
        :VL_DOC,
        :VL_DESC,
        :VL_FORN,
        :VL_SERV_NT,
        :VL_TERC,
        :VL_DA,
        :VL_BC_ICMS,
        :VL_ICMS,
        :VL_BC_ICMS_ST,
        :VL_ICMS_ST,
        :COD_INF,
        :VL_PIS,
        :VL_COFINS,
        :TP_LIGACAO,
        :COD_GRUPO_TENSAO
    DO
    BEGIN
        SUSPEND;

    END

END
