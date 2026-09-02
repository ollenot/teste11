using System;

namespace ProdamSP.Clean.Domain.Models
{
    public class UsuarioModel
    {
        public int CdUsuario { get; set; }

        public string CdLoginUsuario { get; set; }

        public string NmUsuario { get; set; }

        public int CdGrupoCac { get; set; }

        public string? DcUnidade { get; set; }

        public string? DcCargo { get; set; }

        public string StUsuario { get; set; }

        public string? DcEmail { get; set; }

        public string? NrCpf { get; set; }

        public string? NrTelefone { get; set; }

        public bool InProcuradorGeral { get; set; }

        public bool InRh { get; set; }

        public bool InChefeRh { get; set; }

        public bool InExibicaoArvoreCalendario { get; set; }

        public DateTime? DtInclusao { get; set; }

        public DateTime? DtAtualizacao { get; set; }

        public string? CdLoginUsuarioAtualizacao { get; set; }

        public DateTime? DtInativacao { get; set; }

        public string? CdLoginUsuarioDacSigpec { get; set; }

        public DateTime? DtCadastroSigpec { get; set; }

        public string? CdSetorLotacaoSigpec { get; set; }

        public string? DcSetorLotacaoSigpec { get; set; }

        public int? CdCargoSigpec { get; set; }

        public string? DcCargoSigpec { get; set; }

        public int CdVinculoSigpec { get; set; }

        public int? CdSecretaria { get; set; }

        public bool InEstudante { get; set; }

        public bool InAmamentando { get; set; }

        public int? CdTipoUsuarioEspecial { get; set; }

        public bool InDesignado { get; set; }

        public int? CdUsuarioChefeDesignado { get; set; }

        public int? CdUsuarioChefeDesignadoSubstituido { get; set; }

        public int? CdChefeSubstituido { get; set; }

        public DateOnly? DtFimSubstituicao { get; set; }

        public bool InUsuarioSubstituidoEspecial { get; set; }

        public bool InAdministradorGlobal { get; set; }

        public int CdEmpresa { get; set; }
    }
}