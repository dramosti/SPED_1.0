using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.PisCofins;

namespace Hlp.Sped.Repository.Implementation.SQLExpressions.PisCofins
{
    public class SqlExpressionsPisCofinsRepository : ISqlExpressionsPisCofinsRepository
    {
        public string GetExpressionNovaSequenciaArquivo()
        {
            return "{CALL SP_NOVA_SEQUENCIA_SPEDPISCOF}";
        }

        public string GetSelectRegistro0400()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO0400(?,?, ?)";
        }
        public string GetDeleteRegistrosGerados()
        {
            return "DELETE FROM SPEDPISCOFINSDET WHERE NR_ARQUIVO = ?";
        }

        public string GetInsertPersistirRegistro()
        {
            return @"INSERT INTO SPEDPISCOFINSDET (NR_ARQUIVO, VL_ORDENACAO_BLOCO, VL_CHAVE_REGISTRO, 
                         TP_REGISTRO, DS_CONTEUDO_REGISTRO, CD_ORDENACAO_REGISTRO) 
                     VALUES ( ?, ?, ?, ?, ?, ?)";
        }

        public string GetSelectRegistrosGerados()
        {
            return @"SELECT DS_CONTEUDO_REGISTRO
                     FROM SPEDPISCOFINSDET
                     WHERE NR_ARQUIVO = ?
                     ORDER BY NR_ARQUIVO, VL_ORDENACAO_BLOCO, CD_ORDENACAO_REGISTRO, VL_CHAVE_REGISTRO";
        }

        public string GetSelectRegistroJaExistente()
        {
            return @"SELECT COUNT(1) AS EXISTE_REGISTRO FROM SPEDPISCOFINSDET
                     WHERE NR_ARQUIVO = ? AND 
                           TP_REGISTRO = ? AND 
                           VL_CHAVE_REGISTRO = ?";
        }

        public string GetSelectQuantidadeRegistrosBloco()
        {
            return @"SELECT COUNT(1) AS QTD_REGISTROS FROM SPEDPISCOFINSDET
                     WHERE NR_ARQUIVO = ? AND 
                           TP_REGISTRO LIKE ? || '%' AND 
                           TP_REGISTRO NOT LIKE '%001'";
        }

        public string GetSelectRegistro0000()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTRO0000(?)";
        }

        public string GetSelectRegistro0100()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTRO0100(?)";
        }

        public string GetSelectRegistro0110()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTRO0110(?)";
        }

        public string GetSelectRegistro0140()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTRO0140(?)";
        }

        public string GetSelectRegistro0150()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTRO0150(?)";
        }

        public string GetSelectRegistro0190()
        {
            return @"SELECT * FROM SP_SPED_PISCOF_REGISTRO0190(?)";
        }

        public string GetSelectRegistro0200()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTRO0200(?, ?)";
        }

        public string GetSelectRegistro0990()
        {
            return @"SELECT '0990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_0
                     FROM SPEDPISCOFINSDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE '0%'";
        }

        public string GetSelectRegistrosA010()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROA010(?, ?, ?)";
        }

        public string GetSelectRegistrosA100()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROA100(?, ?, ?, ?)";
        }

        public string GetSelectRegistrosA170()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROA170(?, ?)";
        }

        public string GetSelectRegistroA990()
        {
            return @"SELECT 'A990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_A
                     FROM SPEDPISCOFINSDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE 'A%'";
        }

        public string GetSelectRegistrosC010()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC010(?, ?, ?)";
        }

        public string GetSelectRegistrosC100()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC100(?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC120()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC120(?, ?)";
        }

        public string GetSelectRegistrosC170()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC170(?, ?)";
        }

        public string GetSelectRegistrosC180()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC180(?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC181()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC181(?, ?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC185()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC185(?, ?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC190()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC190(?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC191()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC191(?, ?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC195()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC195(?, ?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC199()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC199(?, ?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC380()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC380(?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC381()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC381(?, ?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC385()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC385(?, ?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC400()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC400(?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC405()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC405(?, ?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC481()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC481(?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC485()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC485(?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC500()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC500(?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC501()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC501(?, ?)";
        }

        public string GetSelectRegistrosC505()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTROC505(?, ?)";
        }

        public string GetSelectRegistroC990()
        {
            return @"SELECT 'C990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_C
                     FROM SPEDPISCOFINSDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE 'C%'";
        }

        public string GetSelectRegistroD990()
        {
            return @"SELECT 'D990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_D
                     FROM SPEDPISCOFINSDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE 'D%'";
        }

        public string GetSelectRegistroF990()
        {
            return @"SELECT 'F990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_F
                     FROM SPEDPISCOFINSDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE 'F%'";
        }

        public string GetSelectRegistroM990()
        {
            return @"SELECT 'M990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_M
                     FROM SPEDPISCOFINSDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE 'M%'";
        }

        public string GetSelectRegistroP990()
        {
            return @"SELECT 'P990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_P
                     FROM SPEDPISCOFINSDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE 'P%'";
        }

        public string GetSelectRegistro1990()
        {
            return @"SELECT '1990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_1
                     FROM SPEDPISCOFINSDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE '1%'";
        }

        public string GetSelectRegistros9900()
        {
            return @"SELECT
                         VL_ORDENACAO_BLOCO,
                         TP_REGISTRO AS REG_BLC,
                         CAST(COUNT(1) AS INTEGER) AS QTD_REG_BLC,
                         '9900' AS REG
                     FROM SPEDPISCOFINSDET
                     WHERE NR_ARQUIVO = ?
                     GROUP BY VL_ORDENACAO_BLOCO, TP_REGISTRO ";
        }

        public string GetSelectRegistro9990()
        {
            return @"SELECT '9990' AS REG, CAST(COUNT(1) + 2 AS INTEGER) AS QTD_LIN_9
                     FROM SPEDPISCOFINSDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE '9%'";
        }

        public string GetSelectRegistro9999()
        {
            return @"SELECT '9999' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN
                     FROM SPEDPISCOFINSDET
                     WHERE NR_ARQUIVO = ?";
        }


        public string GetSelectRegistro0500()
        {
            return "SELECT * FROM SP_SPED_PISCOF_REGISTRO0500(?)";
        }       
    }
}
