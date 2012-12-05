CREATE PROCEDURE SP_SPED_FISCAL_REGISTROC510 (
    CD_EMPRESA VARCHAR(3),
    NR_SEQNF VARCHAR(7))
RETURNS (
    COD_ITEM VARCHAR(60),
    COD_CLASS VARCHAR(4),
    QTD NUMERIC(15,5),
    UNID VARCHAR(60),
    VL_ITEM NUMERIC(15,2),
    VL_DESC NUMERIC(15,2),
    CST_ICMS VARCHAR(7),
    CFOP VARCHAR(4),
    ALIQ_ICMS NUMERIC(15,4),
    VL_BC_ICMS NUMERIC(15,2),
    VL_ICMS NUMERIC(15,2),
    VL_BC_ICMS_ST NUMERIC(15,2),
    ALIQ_ST NUMERIC(15,4),
    VL_ICMS_ST NUMERIC(15,2),
    IND_REC VARCHAR(1),
    COD_PART VARCHAR(60),
    VL_PIS NUMERIC(15,2),
    VL_COFINS NUMERIC(15,2),
    COD_CTA VARCHAR(100))
AS
BEGIN

    -- PESQUISAR INFORMAÇÕES DA TABELA NOTAITEM
    -- TODOS OS DADOS AQUI SÃO FAKE, ENTÃO A LÓGICA NÃO É
    -- NECESSARIAMENTE O QUE SERÁ DEFINIDO COMO VERSÃO FINAL
    
    VL_BC_ICMS_ST = 0;
    ALIQ_ST = 0;
    VL_ICMS_ST = 0;

    VL_PIS = 0;

    IND_REC = 0;

    VL_COFINS = 0;

    COD_CTA = NULL;


    FOR SELECT
            '0000007' AS COD_ITEM,
            '123' AS CST_ICMS,
            'PR' AS UNID,
            '5101' AS CFOP,
            1 AS QTD,
            1.01 AS VL_ITEM,
            1.02 AS VL_DESC,
            1.04 AS VL_BC_ICMS,
            1.05 AS ALIQ_ICMS,
            1.06 AS VL_ICMS,
            '0000067' AS COD_PART
        FROM   RDB$DATABASE
        UNION
        SELECT
            '0000013' AS COD_ITEM,
            '456' AS CST_ICMS,
            'GL' AS UNID,
            '6101' AS CFOP,
            2 AS QTD,
            2.01 AS VL_ITEM,
            2.02 AS VL_DESC,
            2.04 AS VL_BC_ICMS,
            2.05 AS ALIQ_ICMS,
            2.06 AS VL_ICMS,
            '0000068' AS COD_PART
        FROM   RDB$DATABASE
        INTO
            :COD_ITEM,
            :CST_ICMS,
            :UNID,
            :CFOP,
            :QTD,
            :VL_ITEM,
            :VL_DESC,
            :VL_BC_ICMS,
            :ALIQ_ICMS,
            :VL_ICMS,
            :COD_PART
    DO
    BEGIN
        SUSPEND;
    END

END
