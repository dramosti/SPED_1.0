﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Repository.Interfaces.SQLExpressions.Fiscal
{
    public interface ISqlExpressionsFiscalRepository
    {
        string GetExpressionNovaSequenciaArquivo();
        string GetDeleteRegistrosGerados();
        string GetInsertPersistirRegistro();
        string GetSelectRegistrosGerados();
        string GetSelectRegistroJaExistente();
        string GetSelectQuantidadeRegistrosBloco();

        string GetSelectRegistroK100();
        string GetSelectRegistroK200();
        string GetSelectRegistroK220();
        string GetSelectRegistroK230();
        string GetSelectRegistroK235();
        string GetSelectRegistroK250();
        string GetSelectRegistroK255();       

        string GetSelectRegistro0000();
        string GetSelectRegistro0005();
        string GetSelectRegistro0100();
        string GetSelectRegistro0150();
        string GetSelectRegistro0190();
        string GetSelectRegistro0200();
        string GetSelectRegistro0210();
        string GetSelectRegistro0220();
        string GetSelectRegistro0400();
        string GetSelectRegistro0500();
        string GetSelectRegistro0990();
        string GetSelectRegistrosC100();
        string GetSelectRegistrosC170();
        string GetSelectRegistrosC190();
        string GetSelectRegistrosC400();
        string GetSelectRegistrosC405();
        string GetSelectRegistroC410();
        string GetSelectRegistrosC420();
        string GetSelectRegistrosC425();
        string GetSelectRegistrosC460();
        string GetSelectRegistrosC470();
        string GetSelectRegistrosC490();
        string GetSelectRegistrosC500();
        string GetSelectRegistrosC510();
        string GetSelectRegistrosC590();
        string GetSelectRegistroC990();
        string GetSelectRegistrosD100();
        string GetSelectRegistrosD110();
        string GetSelectRegistrosD120();
        string GetSelectRegistrosD130();
        string GetSelectRegistrosD190();
        string GetSelectRegistrosD500();
        string GetSelectRegistrosD590();
        string GetSelectRegistroD990();
        string GetSelectRegistrosE500();
        string GetSelectRegistrosE510();
        string GetSelectRegistroE520();
        string GetSelectRegistrosE530();
        string GetSelectRegistroE990();
        string GetSelectRegistroK990();
        string GetSelectRegistroG990();
        string GetSelectRegistrosH005();
        string GetSelectRegistrosH010();
        string GetSelectRegistroH990();
        string GetSelectRegistro1010();
        string GetSelectRegistros1100();
        string GetSelectRegistros1105();
        string GetSelectRegistros1110();
        string GetSelectRegistros1200();
        string GetSelectRegistros1210();
        string GetSelectRegistros1400();
        string GetSelectRegistros1600();
        string GetSelectRegistros1700();
        string GetSelectRegistros1710();
        string GetSelectRegistro1990();
        string GetSelectRegistros9900();
        string GetSelectRegistro9990();
        string GetSelectRegistro9999();
        string GetSelectRegistroE100();
        string GetSelectRegistroE110();
        string GetSelectRegistroE111();
        string GetSelectRegistroE116();

        string GetSelectRegistroE200();
        string GetSelectRegistroE210();
        string GetSelectRegistroE250();
    }
}
