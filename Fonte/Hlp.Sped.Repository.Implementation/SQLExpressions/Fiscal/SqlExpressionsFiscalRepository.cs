using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Fiscal;

namespace Hlp.Sped.Repository.Implementation.SQLExpressions.Fiscal
{
    public class SqlExpressionsFiscalRepository : ISqlExpressionsFiscalRepository
    {
        public string GetExpressionNovaSequenciaArquivo()
        {
            return "{CALL SP_NOVA_SEQUENCIA_SPEDFISCAL}";
        }

        public string GetDeleteRegistrosGerados()
        {
            return "DELETE FROM SPEDFISCALDET WHERE NR_ARQUIVO = ?";
        }

        public string GetInsertPersistirRegistro()
        {
            return @"INSERT INTO SPEDFISCALDET (NR_ARQUIVO, VL_ORDENACAO_BLOCO, VL_CHAVE_REGISTRO, 
                         TP_REGISTRO, DS_CONTEUDO_REGISTRO, CD_ORDENACAO_REGISTRO) 
                     VALUES ( ?, ?, ?, ?, ?, ?)";
        }

        public string GetSelectRegistrosGerados()
        {
            return @"SELECT DS_CONTEUDO_REGISTRO
                     FROM SPEDFISCALDET
                     WHERE NR_ARQUIVO = ?
                     ORDER BY NR_ARQUIVO, VL_ORDENACAO_BLOCO, CD_ORDENACAO_REGISTRO, VL_CHAVE_REGISTRO";
        }

        public string GetSelectRegistroJaExistente()
        {
            return @"SELECT COUNT(1) AS EXISTE_REGISTRO FROM SPEDFISCALDET
                     WHERE NR_ARQUIVO = ? AND 
                           TP_REGISTRO = ? AND 
                           VL_CHAVE_REGISTRO = ?";
        }

        public string GetSelectQuantidadeRegistrosBloco()
        {
            return @"SELECT COUNT(1) AS QTD_REGISTROS FROM SPEDFISCALDET
                     WHERE NR_ARQUIVO = ? AND 
                           TP_REGISTRO LIKE ? || '%' AND 
                           TP_REGISTRO NOT LIKE '%001'";
        }

        public string GetSelectRegistro0000()
        {
            return @"SELECT * FROM SP_SPED_FISCAL_REGISTRO0000(?)";
        }

        public string GetSelectRegistro0005()
        {
            return @"SELECT * FROM SP_SPED_FISCAL_REGISTRO0005(?)";
        }

        public string GetSelectRegistro0100()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO0100(?)";
        }

        public string GetSelectRegistro0150()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO0150(?)";
        }

        public string GetSelectRegistro0190()
        {
            return @"SELECT * FROM SP_SPED_FISCAL_REGISTRO0190(?)";
        }

        public string GetSelectRegistro0200()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO0200(?, ?)";
        }

        public string GetSelectRegistro0400()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO0400(?,?, ?)";
        }

        public string GetSelectRegistro0500()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO0500(?)";
        }       

        public string GetSelectRegistro0990()
        {
            return @"SELECT '0990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_0
                     FROM SPEDFISCALDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE '0%'";
        }

        public string GetSelectRegistrosC100()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROC100(?, ?, ?)";
        }

        public string GetSelectRegistrosC170()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROC170(?, ?)";
        }

        public string GetSelectRegistrosC190()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROC190(?, ?)";
        }

        public string GetSelectRegistrosC400()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROC400(?, ?, ?)";
        }

        public string GetSelectRegistrosC405()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROC405(?, ?, ?, ?)";
        }

        public string GetSelectRegistroC410()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROC410(?, ?, ?)";
        }

        public string GetSelectRegistrosC420()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROC420(?, ?, ?)";
        }

        public string GetSelectRegistrosC425()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROC425(?, ?, ?, ?)";
        }

        public string GetSelectRegistrosC460()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROC460(?, ?, ?)";
        }

        public string GetSelectRegistrosC470()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROC470(?, ?)";
        }

        public string GetSelectRegistrosC490()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROC490(?, ?, ?)";
        }

        public string GetSelectRegistrosC500()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROC500(?, ?, ?)";
        }

        public string GetSelectRegistrosC510()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROC510(?, ?)";
        }

        public string GetSelectRegistrosC590()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROC590(?, ?)";
        }

        public string GetSelectRegistroC990()
        {
            return @"SELECT 'C990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_C
                     FROM SPEDFISCALDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE 'C%'";
        }

        public string GetSelectRegistrosD100()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROD100(?, ?, ?)";
        }

        public string GetSelectRegistrosD110()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROD110(?, ?)";
        }

        public string GetSelectRegistrosD120()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROD120(?, ?)";
        }

        public string GetSelectRegistrosD130()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROD130(?, ?)";
        }

        public string GetSelectRegistrosD190()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROD190(?, ?)";
        }

        public string GetSelectRegistrosD500()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROD500(?, ?, ?)";
        }

        public string GetSelectRegistrosD590()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROD590(?, ?)";
        }

        public string GetSelectRegistroD990()
        {
            return @"SELECT 'D990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_D
                     FROM SPEDFISCALDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE 'D%'";
        }

        public string GetSelectRegistrosE500()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROE500(?, ?, ?)";
        }

        public string GetSelectRegistrosE510()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROE510(?, ?, ?)";
        }

        public string GetSelectRegistroE520()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROE520(?, ?, ?)";
        }

        public string GetSelectRegistrosE530()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROE530(?, ?, ?)";
        }

        public string GetSelectRegistroE990()
        {
            return @"SELECT 'E990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_E
                     FROM SPEDFISCALDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE 'E%'";
        }

        public string GetSelectRegistroG990()
        {
            return @"SELECT 'G990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_G
                     FROM SPEDFISCALDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE 'G%'";
        }

        public string GetSelectRegistrosH005()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROH005(?, ?, ?)";
        }

        public string GetSelectRegistrosH010()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROH010(?, ?)";
        }

        public string GetSelectRegistroH990()
        {
            return @"SELECT 'H990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_H
                     FROM SPEDFISCALDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE 'H%'";
        }

        public string GetSelectRegistro1010()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO1010(?, ?, ?)";
        }

        public string GetSelectRegistros1100()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO1100(?, ?, ?)";
        }

        public string GetSelectRegistros1105()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO1105(?, ?, ?, ?)";
        }

        public string GetSelectRegistros1110()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO1110(?, ?)";
        }

        public string GetSelectRegistros1200()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO1200(?, ?, ?)";
        }

        public string GetSelectRegistros1210()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO1210(?, ?, ?, ?)";
        }

        public string GetSelectRegistros1400()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO1400(?, ?, ?)";
        }

        public string GetSelectRegistros1600()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO1600(?, ?, ?)";
        }

        public string GetSelectRegistros1700()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO1700(?, ?, ?)";
        }

        public string GetSelectRegistros1710()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTRO1710(?, ?, ?, ?, ?, ?, ?)";
        }
        
        public string GetSelectRegistro1990()
        {
            return @"SELECT '1990' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN_1
                     FROM SPEDFISCALDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE '1%'";
        }

        public string GetSelectRegistros9900()
        {
            return @"SELECT
                         VL_ORDENACAO_BLOCO,
                         TP_REGISTRO AS REG_BLC,
                         CAST(COUNT(1) AS INTEGER) AS QTD_REG_BLC,
                         '9900' AS REG
                     FROM SPEDFISCALDET
                     WHERE NR_ARQUIVO = ?
                     GROUP BY VL_ORDENACAO_BLOCO, TP_REGISTRO ";
        }

        public string GetSelectRegistro9990()
        {
            return @"SELECT '9990' AS REG, CAST(COUNT(1) + 2 AS INTEGER) AS QTD_LIN_9
                     FROM SPEDFISCALDET
                     WHERE NR_ARQUIVO = ? AND TP_REGISTRO LIKE '9%'";
        }

        public string GetSelectRegistro9999()
        {
            return @"SELECT '9999' AS REG, CAST(COUNT(1) + 1 AS INTEGER) AS QTD_LIN
                     FROM SPEDFISCALDET
                     WHERE NR_ARQUIVO = ?";
        }
        public string GetSelectRegistroE100()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROE100(?, ?, ?)";
        }

        public string GetSelectRegistroE110()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROE110(?,?,?)";
        }

        public string GetSelectRegistroE111()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROE111(?,?,?)";
        }

        public string GetSelectRegistroE116()
        {
            return "SELECT * FROM SP_SPED_FISCAL_REGISTROE116(?,?,?)";
        }


        public string GetSelectRegistro0220()
        {
             return "SELECT * FROM SP_SPED_FISCAL_REGISTRO0220(?, ?)";
        }
    }
}
