CREATE PROCEDURE SP_SPED_FISCAL_REGISTROD100 (
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
    NUM_DOC VARCHAR(20),
    CHV_CTE VARCHAR(44),
    DT_DOC DATE,
    DT_A_P DATE,
    TP_CT_E VARCHAR(1),
    CHV_CTE_REF VARCHAR(44),
    VL_DOC NUMERIC(15,2),
    VL_DESC NUMERIC(15,2),
    IND_FRT VARCHAR(1),
    VL_SERV NUMERIC(15,2),
    VL_BC_ICMS NUMERIC(15,2),
    VL_ICMS NUMERIC(15,2),
    VL_NT NUMERIC(15,2),
    COD_INF VARCHAR(6),
    COD_CTA VARCHAR(100)
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
        '000001' AS NUM_DOC,
        '0000000011' AS CHV_CTE,    
        :DT_EMI_INICIAL AS DT_DOC,
        :DT_EMI_INICIAL AS DT_A_P,
        '1' AS TP_CT_E,
        '0000000011' AS CHV_CTE_REF,    
        1001.01 AS VL_DOC,
        0.01 AS VL_DESC,
        '1' AS IND_FRT,
        0.02 AS VL_SERV,
        0.05 AS VL_BC_ICMS,
        0.06 AS VL_ICMS,
        0.03 AS VL_NT,
        NULL AS COD_INF,
        NULL AS COD_CTA
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
        '000002' AS NUM_DOC,
        '0000000022' AS CHV_CTE,
        :DT_EMI_INICIAL AS DT_DOC,
        :DT_EMI_INICIAL AS DT_A_P,
        '1' AS TP_CT_E,
        '0000000022' AS CHV_CTE_REF,
        20002.22 AS VL_DOC,
        1.01 AS VL_DESC,
        '2' AS IND_FRT,
        1.02 AS VL_SERV,
        1.05 AS VL_BC_ICMS,
        1.06 AS VL_ICMS,
        1.03 AS VL_NT,
        NULL AS COD_INF,
        NULL AS COD_CTA
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
        '000003' AS NUM_DOC,
        '0000000033' AS CHV_CTE,
        :DT_EMI_FINAL AS DT_DOC,
        :DT_EMI_FINAL AS DT_A_P,
        '1' AS TP_CT_E,
        '0000000033' AS CHV_CTE_REF,
        3003.03 VL_DOC,
        10.01 AS VL_DESC,
        '9' AS IND_FRT,
        10.02 AS VL_SERV,
        10.05 AS VL_BC_ICMS,
        10.06 AS VL_ICMS,
        10.03 AS VL_NT,
        NULL AS COD_INF,
        NULL AS COD_CTA
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
        :NUM_DOC,
        :CHV_CTE,
        :DT_DOC,
        :DT_A_P,
        :TP_CT_E,
        :CHV_CTE_REF,
        :VL_DOC,
        :VL_DESC,
        :IND_FRT,
        :VL_SERV,
        :VL_BC_ICMS,
        :VL_ICMS,
        :VL_NT,
        :COD_INF,
        :COD_CTA
    DO
    BEGIN
        SUSPEND;
    END

END
