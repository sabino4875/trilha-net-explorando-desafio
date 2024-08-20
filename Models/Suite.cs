namespace DesafioProjetoHospedagem.Models
{
    using System;
    using System.ComponentModel;
    using System.Globalization;

    enum TipoSuite
    {
        [Description("Premium")]
        PREMIUM,
        [Description("Super")]
        SUPER,
        [Description("Standard")]
        STANDARD
    }

    /// <summary>
    /// Classe que representa uma su�te do hotel
    /// </summary>
    /// <param name="tipoSuite">Tipo de su�te</param>
    /// <param name="capacidade">Quantidade de h�spedes da su�te</param>
    /// <param name="valorDiaria">Valor da di�ria</param>
    public class Suite(String tipoSuite, Int32 capacidade, Decimal valorDiaria)
    {

        /// <summary>
        /// M�todo construtor da classe
        /// </summary>
        public Suite() : this(String.Empty, 0, Decimal.Zero)
        { 
        }

        /// <summary>
        /// Tipo de su�te
        /// </summary>
        public String TipoSuite { get; set; } = tipoSuite;

        /// <summary>
        /// Quantidade de h�spedes da su�te
        /// </summary>
        public Int32 Capacidade { get; set; } = capacidade;

        /// <summary>
        /// Valor da di�ria
        /// </summary>
        public Decimal ValorDiaria { get; set; } = valorDiaria;

        /// <summary>
        /// Retorna uma representa��o da classe utilizando uma estrutura espec�fica
        /// </summary>
        /// <returns>Uma String com os valores da classe interpolados</returns>
        public override String ToString()
        {
            return $"Tipo de su�te: {TipoSuite} - Capacidade: {Capacidade} pessoas - Valor da di�ria: {ValorDiaria.ToString("C2", CultureInfo.CurrentCulture)}";
        }
    }
}