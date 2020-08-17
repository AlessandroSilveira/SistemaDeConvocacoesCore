$(document).ready(function ($) {
    $("#DataEntregaDocumentos").mask("00/00/0000");
    $("#HorarioEntregaDocumento").mask("00:00");

    var dados = $("#mostraConfirmacao").val();

    if (dados === "value") {
        $("#mensagem_sucesso").trigger("click");
    }

    $("#envia_selecionados").click(function () {
        var convocados = [];

        $("input[name=Convocado]").each(function () {
            if (this.checked === true) {
                convocados.push($(this).val());
            }
            $("#CandidatosSelecionados").val(convocados);
        });

        if (convocados.length === 0) {
            $("#mensagemNenhumCandidato").trigger("click");
        }
        else {
            $("#mensagemDadosConvocados").trigger("click");
        }
    });
    
    $("#salvar").click(function(){
       if($("#DataEntregaDocumentos").val()==="" ||$("#DataEntregaDocumentos").val()==null){
           alert("Informe a Data da entrega dos documentos.");
           return false
       }
        if($("#HorarioEntregaDocumento").val()==="" ||$("#HorarioEntregaDocumento").val()==null){
            alert("Informe o Horário de entrega dos documentos.");
            return false
        }
        if($("#EnderecoEntregaDocumento").val()==="" ||$("#EnderecoEntregaDocumento").val()==null){
            alert("Informe o Endereço de Entrega dos documentos.");
            return false
        }
        $("#form").submit();
        
    });
    

    $("#DataEntregaDocumentos").datepicker({
        dateFormat: 'dd/mm/yy',
        dayNames: ['Domingo', 'Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Sábado'],
        dayNamesMin: ['D', 'S', 'T', 'Q', 'Q', 'S', 'S', 'D'],
        dayNamesShort: ['Dom', 'Seg', 'Ter', 'Qua', 'Qui', 'Sex', 'Sáb', 'Dom'],
        monthNames: ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'],
        monthNamesShort: ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'],
        nextText: 'Próximo',
        prevText: 'Anterior'
    });
});