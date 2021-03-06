﻿using Impacta.Apoio;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina.WindowsForms
{
    public partial class VeiculoForm : Form
    {
        public VeiculoForm()
        {
            InitializeComponent();
            PopularControles();
        }

        private void PopularControles()
        {
            //marcaComboBox.SelectedIndexChanged += null;
            marcaComboBox.DataSource = new MarcaRepositorio().Selecionar();
            marcaComboBox.DisplayMember = "Nome";
            marcaComboBox.ValueMember = "Id";
            marcaComboBox.SelectedIndex = -1;
            //marcaComboBox.SelectedIndexChanged += marcaComboBox_SelectedIndexChanged;

            corComboBox.DataSource = new Oficina.Repositorios.SqlServer.CorRepositorio().Selecionar();
            corComboBox.DisplayMember = "Nome";
            corComboBox.ValueMember = "Id";
            corComboBox.SelectedIndex = -1;

            combustivelComboBox.DataSource = Enum.GetValues(typeof(Combustivel));
            combustivelComboBox.SelectedIndex = -1;

            cambioComboBox.DataSource = Enum.GetValues(typeof(Cambio));
            cambioComboBox.SelectedIndex = -1;
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            //var formulario = new Formulario();

            if (Formulario.Validar(this, veiculoErrorProvider))
            {
                try
                {
                    //throw new Exception("O resumo do erro.");

                    GravarVeiculo();

                    MessageBox.Show("Veículo gravado com sucesso!");

                    Formulario.Limpar(this);

                    placaMaskedTextBox.Focus();
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox
                        .Show("Uma parte do caminho do arquivo de Veículo não foi encontrada. A gravação não foi realizada.");
                }
                catch (FileNotFoundException)
                {
                    MessageBox
                        .Show("O arquivo de Veículo não foi encontrado. A gravação não foi realizada.");
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("O arquivo Veiculo.xml não tem permissão de gravação.");
                }
                catch (Exception excecao)
                {
                    MessageBox.Show("Houve um erro e a gravação não foi realizada.");

                    log4net.LogManager.GetLogger(nameof(VeiculoForm))
                        .Error(excecao.Message, excecao);
                }
            }
        }

        private void GravarVeiculo()
        {
            var veiculo = new VeiculoPasseio();

            veiculo.Ano = Convert.ToInt32(anoMaskedTextBox.Text);
            veiculo.Cambio = (Cambio)cambioComboBox.SelectedItem;
            veiculo.Carroceria = Carroceria.Hatch;
            veiculo.Combustivel = (Combustivel)combustivelComboBox.SelectedItem;
            veiculo.Cor = (Cor)corComboBox.SelectedItem;
            veiculo.Modelo = (Modelo)modeloComboBox.SelectedItem;
            veiculo.Observacao = observacaoTextBox.Text;
            veiculo.Placa = placaMaskedTextBox.Text;

            //var repositorio = new VeiculoRepositorio();
            //repositorio.Inserir(veiculo);
            new VeiculoRepositorio().Inserir(veiculo);
        }

        private void marcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marcaComboBox.SelectedIndex == -1)
            {
                //modeloComboBox.DataSource = null;
                return;
            }

            var marca = (Marca)marcaComboBox.SelectedItem;

            modeloComboBox.DataSource =
                new ModeloRepositorio().SelecionarPorMarca(marca.Id);
            modeloComboBox.DisplayMember = "Nome";
            modeloComboBox.ValueMember = "Id";
            modeloComboBox.SelectedIndex = -1;
        }

        private void observacaoTextBox_TextChanged(object sender, EventArgs e)
        {
            //observacaoGroupBox.Text =
            //    $"Observação ({observacaoTextBox.MaxLength - observacaoTextBox.Text.Length })";

            observacaoGroupBox.Text =
                $"Observação ({observacaoTextBox.MaxLength - observacaoTextBox.TextLength })";

        }
    }
}
