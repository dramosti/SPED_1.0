using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contabil;

namespace Hlp.Sped.Repository.Implementation.SQLExpressions.Contabil
{
    public class SqlExpressionsContabilRepository : ISqlExpressionsContabilRepository
    {
        #region Metódos Comnuns

        public string GetExpressionNovaSequenciaArquivo()
        {
            return "{CALL SP_NOVA_SEQUENCIA_SPEDCONTABIL}";
        }

        public string GetDeleteRegistrosGerados()
        {
            return "DELETE FROM SPEDCONTABILDET WHERE NR_ARQUIVO = ?";
        }

        public string GetInsertPersistirRegistro()
        {
            return @"INSERT INTO SPEDCONTABILDET (NR_ARQUIVO, 
                         VL_ORDENACAO_BLOCO, VL_CHAVE_REGISTRO, TP_REGISTRO, DS_CONTEUDO_REGISTRO, CD_ORDENACAO_REGISTRO) 
                     VALUES ( ?, ?, ?, ?, ?, ?)";
        }

        public string GetSelectRegistrosGerados()
        {
            return @"SELECT DS_CONTEUDO_REGISTRO
                     FROM SPEDCONTABILDET
                     WHERE NR_ARQUIVO = ?
                     ORDER BY NR_ARQUIVO, VL_ORDENACAO_BLOCO, CD_ORDENACAO_REGISTRO, VL_CHAVE_REGISTRO";
        }

        public string GetSelectRegistroJaExistente()
        {
            return @"SELECT COUNT(1) AS EXISTE_REGISTRO FROM SPEDCONTABILDET
                     WHERE NR_ARQUIVO = ? AND 
                           TP_REGISTRO = ? AND 
                           VL_CHAVE_REGISTRO = ?";
        }

        #endregion

        #region Metódos Públicos - Abertura Contábil

        public string GetSelectRegistro0000()
        {
            return "SELECT * FROM SP_SPED_CONTABIL_REGISTRO0000(?)";
        }

        public string GetSelectRegistro0007()
        {
            return "SELECT * FROM SP_SPED_CONTABIL_REGISTRO0007(?)";
        }

        public string GetSelectRegistro0020()
        {
            return "SELECT * FROM SP_SPED_CONTABIL_REGISTRO0020(?)";
        }

        public string GetSelectRegistro0150()
        {
            return @"SELECT * FROM SP_SPED_CONTABIL_REGISTRO0150(?)";
        }

        public string GetSelectRegistro0180()
        {
            return @"SELECT * FROM SP_SPED_CONTABIL_REGISTRO0180(?)";
        }

        public string GetSelectRegistro0990()
        {
            return @"SELECT '0990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_0
                     FROM SPEDCONTABILDET
                     WHERE NR_ARQUIVO = ?";
        }
        
        #endregion

        #region Metódos Públicos - Lançamento Contábil
        
        public string GetSelectRegistroI001()
        {
            return @"SELECT 'I001' AS REG, 0 AS IND_DAD
                     FROM SPEDCONTABILDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO = ?";
        }

        public string GetSelectRegistroI010()
        {
            return @"SELECT * FROM SP_SPED_CONTABIL_REGISTROI010(?)";
        }

        public string GetSelectRegistroI012()
        {
            return @"";
        }

        public string GetSelectRegistroI015()
        {
            return @"";
        }

        public string GetSelectRegistroI020()
        {
            return @"";
        }

        public string GetSelectRegistroI030()
        {
            return @"";
        }

        public string GetSelectRegistrosI050()
        {
            return "SELECT * FROM SP_SPED_CONTABIL_REGISTROI050(?, ?, ?)";
        }

        public string GetSelectRegistroI075()
        {
            return "SELECT * FROM SP_SPED_CONTABIL_REGISTROI075(?)";
        }

        public string GetSelectRegistroI100()
        {
            return @"";            
        }

        public string GetSelectRegistroI151()
        {
            return @"";
        }

        public string GetSelectRegistrosI155()
        {
            return "SELECT * FROM SP_SPED_CONTABIL_REGISTROI155(?, ?, ?)";
        }

        public string GetSelectRegistrosI200()
        {
            return "SELECT * FROM SP_SPED_CONTABIL_REGISTROI200(?, ?, ?)";
        }

        public string GetSelectRegistrosI250()
        {
            return "SELECT * FROM SP_SPED_CONTABIL_REGISTROI250(?, ?)";
        }

        public string GetSelectRegistrosI300()
        {
            return "SELECT * FROM SP_SPED_CONTABIL_REGISTROI300(?, ?, ?)";
        }

        public string GetSelectRegistrosI310()
        {
            return "SELECT * FROM SP_SPED_CONTABIL_REGISTROI310(?, ?)";
        }

        public string GetSelectRegistroI350()
        {
            return @"";
        }

        public string GetSelectRegistroI355()
        {
            return @"";
        }

        public string GetSelectRegistroI500()
        {
            return @"";
        }

        public string GetSelectRegistroI510()
        {
            return @"";
        }

        public string GetSelectRegistroI550()
        {
            return @"";
        }

        public string GetSelectRegistroI555()
        {
            return @"";
        }

        public string GetSelectRegistroI990()
        {
            return @"SELECT 'I990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_I
                     FROM SPEDCONTABILDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE 'I%'";
        }

        #endregion

        #region Métodos públicos - Demonstrações Contábeis

        public string GetSelectRegistrosJ930()
        {
            return "SELECT * FROM SP_SPED_CONTABIL_REGISTROJ930(?)";
        }

        public string GetSelectRegistroJ990()
        {
            return @"SELECT 'J990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_J
                     FROM SPEDCONTABILDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE 'J%'";
        }

        #endregion

        #region Métodos públicos - Bloco de Encerramento

        public string GetSelectRegistros9900()
        {
            return @"SELECT
                         VL_ORDENACAO_BLOCO,
                         TP_REGISTRO AS REG_BLC,
                         CAST(COUNT(1) AS INTEGER) AS QTD_REG_BLC,
                         '9900' AS REG
                     FROM SPEDCONTABILDET
                     WHERE NR_ARQUIVO = ?
                     GROUP BY VL_ORDENACAO_BLOCO, TP_REGISTRO ";
        }

        public string GetSelectRegistro9990()
        {
            return @"SELECT '9990' AS REG, CAST(COUNT(1) + 2 AS INTEGER) AS QTD_LIN_9
                     FROM SPEDCONTABILDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE '9%'";
        }

        public string GetSelectRegistro9999()
        {
            return @"SELECT '9999' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN
                     FROM SPEDCONTABILDET
                     WHERE NR_ARQUIVO = ?";
        }

        #endregion
    }
}
