using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Repository.Interfaces.SQLExpressions.PisCofins
{
    public interface ISqlExpressionsPisCofinsRepository
    {
        string GetExpressionNovaSequenciaArquivo();
        string GetDeleteRegistrosGerados();
        string GetInsertPersistirRegistro();
        string GetSelectRegistrosGerados();
        string GetSelectRegistroJaExistente();
        string GetSelectQuantidadeRegistrosBloco();
        string GetSelectRegistro0000();
        string GetSelectRegistroD500();
        string GetSelectRegistrosD010();
        string GetSelectRegistroD501() ;
        string GetSelectRegistroD505();
        string GetSelectRegistro0400();
        string GetSelectRegistro0500();
        string GetSelectRegistro0100();
        string GetSelectRegistro0110();
        string GetSelectRegistro0140();
        string GetCodEmpresaAfilial(string codEmp);
        string GetSelectRegistro0150();
        string GetSelectRegistro0190();
        string GetSelectRegistro0200();
        string GetSelectRegistro0990();
        string GetSelectRegistrosA010();
        string GetSelectRegistrosA100();
        string GetSelectRegistrosA170();
        string GetSelectRegistroA990();
        string GetSelectRegistrosC010();
        string GetSelectRegistrosC100();
        string GetSelectRegistrosC120();
        string GetSelectRegistrosC170();
        string GetSelectRegistrosC180();
        string GetSelectRegistrosC181();
        string GetSelectRegistrosC185();
        string GetSelectRegistrosC190();
        string GetSelectRegistrosC191();
        string GetSelectRegistrosC195();
        string GetSelectRegistrosC199();
        string GetSelectRegistrosC380();
        string GetSelectRegistrosC381();
        string GetSelectRegistrosC385();
        string GetSelectRegistrosC400();
        string GetSelectRegistrosC405();
        string GetSelectRegistrosC481();
        string GetSelectRegistrosC485(); 
        string GetSelectRegistrosC500();
        string GetSelectRegistrosC501();
        string GetSelectRegistrosC505(); 
        string GetSelectRegistroC990();
        string GetSelectRegistroD990();
        string GetSelectRegistroD100();

        string GetSelectRegistroD200();
        string GetSelectRegistroD201();
        string GetSelectRegistroD205();

        string GetSelectRegistroD101();
        string GetSelectRegistroD105();
        string GetSelectRegistroF990();
        string GetSelectRegistroM990();
        string GetSelectRegistroP990();
        string GetSelectRegistro1990();
        string GetSelectRegistros9900();
        string GetSelectRegistro9990();
        string GetSelectRegistro9999();
        string GetSelectRegistroF010();
        string GetSelectRegistroF600();
        string GetSelectRegistroF200();

    }
}