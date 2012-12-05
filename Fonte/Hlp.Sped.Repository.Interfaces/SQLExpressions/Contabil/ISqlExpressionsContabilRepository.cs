using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Repository.Interfaces.SQLExpressions.Contabil
{
    public interface ISqlExpressionsContabilRepository
    {
        #region Métodos  - Comuns
        
        string GetExpressionNovaSequenciaArquivo();
        string GetDeleteRegistrosGerados();
        string GetInsertPersistirRegistro();
        string GetSelectRegistrosGerados();
        string GetSelectRegistroJaExistente();
        
        #endregion

        #region Métodos - Abertura Contábil
        
        string GetSelectRegistro0000();
        string GetSelectRegistro0007();
        string GetSelectRegistro0020();
        string GetSelectRegistro0150();
        string GetSelectRegistro0180();
        string GetSelectRegistro0990();
        
        #endregion

        #region Métodos - Lançamento Contábil
        
        string GetSelectRegistroI001();
        string GetSelectRegistroI010();
        string GetSelectRegistroI012();
        string GetSelectRegistroI015();
        string GetSelectRegistroI020();
        string GetSelectRegistroI030();
        string GetSelectRegistrosI050();
        string GetSelectRegistroI075();
        string GetSelectRegistroI100();
        string GetSelectRegistroI151();
        string GetSelectRegistrosI155();
        string GetSelectRegistrosI200();
        string GetSelectRegistrosI250();
        string GetSelectRegistrosI300();
        string GetSelectRegistrosI310();
        string GetSelectRegistroI350();
        string GetSelectRegistroI355();
        string GetSelectRegistroI500();
        string GetSelectRegistroI510();
        string GetSelectRegistroI550();
        string GetSelectRegistroI555();
        string GetSelectRegistroI990();
        
        #endregion


        #region Métodos - Demonstrações Contábeis

        string GetSelectRegistrosJ930();
        string GetSelectRegistroJ990();

        #endregion


        #region Métodos públicos - Bloco de Encerramento

        string GetSelectRegistros9900();
        string GetSelectRegistro9990();
        string GetSelectRegistro9999();

        #endregion
    }
}
