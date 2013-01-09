using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contmatic;

namespace Hlp.Sped.Repository.Implementation.SQLExpressions.Contimatic
{
    public class SqlExpressionsContmaticRepository : ISqlExpressionsContmaticRepository
    {

        public string GetExpressionNovaSequenciaArquivo()
        {
            return "{CALL SP_NOVA_SEQUENCIA_SPEDCONTMATIC}";
        }

        public string GetDeleteRegistrosGerados()
        {
            return "DELETE FROM SPEDCONTMATDET WHERE NR_ARQUIVO = ?";
        }

        public string GetInsertPersistirRegistro()
        {
            return @"INSERT INTO SPEDCONTMATDET (NR_ARQUIVO, VL_ORDENACAO_BLOCO, VL_CHAVE_REGISTRO, 
                         TP_REGISTRO, DS_CONTEUDO_REGISTRO, CD_ORDENACAO_REGISTRO) 
                     VALUES ( ?, ?, ?, ?, ?, ?)";
        }

        public string GetSelectRegistrosGerados()
        {
            return @"SELECT DS_CONTEUDO_REGISTRO
                     FROM SPEDCONTMATDET
                     WHERE NR_ARQUIVO = ?
                     ORDER BY NR_ARQUIVO, VL_ORDENACAO_BLOCO, CD_ORDENACAO_REGISTRO, VL_CHAVE_REGISTRO";
        }

        public string GetSelectRegistroJaExistente()
        {
            return @"SELECT COUNT(1) AS EXISTE_REGISTRO FROM SPEDCONTMATDET
                     WHERE NR_ARQUIVO = ? AND 
                           TP_REGISTRO = ? AND 
                           VL_CHAVE_REGISTRO = ?";
        }

        public string GetSelectQuantidadeRegistrosBloco()
        {
            return @"SELECT COUNT(1) AS QTD_REGISTROS FROM SPEDCONTMATDET
                     WHERE NR_ARQUIVO = ? AND 
                           TP_REGISTRO LIKE ? || '%' AND 
                           TP_REGISTRO NOT LIKE '%001'";
        }



        public string GetSelectRegistro0000()
        {
            return @"SELECT * FROM SP_SPED_CONTMAT_REGISTRO0000(?)";
        }

        public string GetSelectRegistro0100()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTRO0100(?)";
        }

        public string GetSelectRegistro0150()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTRO0150(?)";
        }

        public string GetSelectRegistro0190()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTRO0190(?)";
        }

        public string GetSelectRegistro0200()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTRO0200(?,?)";
        }

        public string GetSelectRegistro0220()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTRO0220(?,?)";
        }

        public string GetSelectRegistro0400()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTRO0400(?,?,?)";
        }

        public string GetSelectRegistro0600()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTRO0600(?)";
        }


        public string GetSelectRegistro1010()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTRO1010(?,?,?)";
        }

        public string GetSelectRegistro1100()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTRO1100(?,?,?)";
        }

        public string GetSelectRegistro1200()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTRO1200(?,?,?)";
        }

        public string GetSelectRegistro1600()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTRO1600(?,?,?)";
        }


        public string GetSelectRegistroA100()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROA100(?,?,?,?)";
        }

        public string GetSelectRegistroA170()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROA170(?,?)";
        }


        public string GetSelectRegistroC100()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROC100(?,?,?)";
        }

        public string GetSelectRegistroC170()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROC170(?,?)";
        }

        public string GetSelectRegistroC400()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROC400(?,?)";
        }

        public string GetSelectRegistroC405()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROC405(?,?,?,?)";
        }

        public string GetSelectRegistroC460()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROC460(?,?,?)";
        }

        public string GetSelectRegistroC470()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROC470(?,?)";
        }

        public string GetSelectRegistroC500()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROC500(?,?,?)";
        }

        public string GetSelectRegistroC510()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROC510(?,?)";
        }


        public string GetSelectRegistroD100()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROD100(?,?,?)";
        }

        public string GetSelectRegistroD101()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROD101(?,?,?)";
        }

        public string GetSelectRegistroD110()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROD110(?,?)";
        }

        public string GetSelectRegistroD120()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROD120(?,?)";
        }

        public string GetSelectRegistroD130()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROD130(?,?)";
        }

        public string GetSelectRegistroD190()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROD190(?,?)";
        }

        public string GetSelectRegistroD500()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROD500(?,?,?)";
        }

        public string GetSelectRegistroD510()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROD510(?,?)";
        }

        public string GetSelectRegistroD590()
        {
            return "SELECT * FROM SP_SPED_CONTMAT_REGISTROD590(?,?)";
        }

    }
}
