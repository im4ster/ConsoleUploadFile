using System;
using System.Collections.Generic;
using System.IO;
using ConsoleApplication1.Entidades;
using ConsoleApplication1.Rules;

namespace ConsoleApplication1
{
    public class ReadFileD
    {
        
        public List<BeneficiarioEntity> beneficiarioList = new List<BeneficiarioEntity>();

        internal bool LoadFile()
        {
            bool result = false;
            try
            {
                Console.WriteLine("Start Load Data");

                string fileName = @"C:\Users\42039\Documents\Personal\MED_SOL_TEST.txt";
                string[] contenidoLineas = File.ReadAllLines(fileName);

                int contador = 0;
                foreach (string line in contenidoLineas)
                {
                    BeneficiarioEntity rowValue = new BeneficiarioEntity();
                    try
                    {
                        //Crea una lista de la clase BeneficiarioEntity                       
                        rowValue = new BeneficiarioEntity
                        {
                            #region Asigna Valores a la lista
                            IdRow = contador,
                            Remesa = line.Substring(0, 7).Trim(),
                            idIntegrante = line.Substring(7, 9).Trim(),
                            idFamilia = line.Substring(16, 9).Trim(),
                            Estado = line.Substring(25, 2).Trim(),
                            descEdo = line.Substring(27, 21).Trim(),
                            znaAtencion = line.Substring(48, 6).Trim(),
                            idMunicipio = line.Substring(54, 3).Trim(),
                            descMunicipio = line.Substring(57, 50).Trim(),
                            idLocalidad = line.Substring(107, 4).Trim(),
                            descLocalidad = line.Substring(111, 50).Trim(),
                            idAGEB = line.Substring(161, 7).Trim(),
                            idColonia = line.Substring(168, 14).Trim(),
                            descColonia = line.Substring(182, 100).Trim(),
                            idEACP = line.Substring(282, 4).Trim(),
                            idSucursal = line.Substring(286, 5).Trim(),
                            idAlmRural = line.Substring(291, 4).Trim(),
                            descAlmRural = line.Substring(295, 50).Trim(),
                            idTienda = line.Substring(345, 3).Trim(),
                            descTienda = line.Substring(348, 50).Trim(),
                            folioTitular = line.Substring(398, 16).Trim(),
                            apellidoPat = line.Substring(414, 30).Trim(),
                            apellidoMat = line.Substring(444, 30).Trim(),
                            nombreTitular = line.Substring(474, 30).Trim(),
                            faseIncorp = line.Substring(504, 2).Trim(),
                            calle = line.Substring(506, 50).Trim(),
                            numExterior = line.Substring(556, 15).Trim(),
                            numInterior = line.Substring(571, 15).Trim(),
                            codPostal = line.Substring(586, 5).Trim(),
                            telefono = line.Substring(591, 30).Trim(),
                            fechaNacim = line.Substring(621, 8).Trim(),
                            sexo = line.Substring(629, 1).Trim(),
                            RFC = line.Substring(630, 10).Trim(),
                            CURP = line.Substring(640, 18).Trim(),
                            folioFormato = line.Substring(658, 19).Trim(),
                            bimestreEmision = line.Substring(677, 9).Trim(),
                            anioEmision = line.Substring(686, 4).Trim(),
                            numText1erDoc = line.Substring(690, 1).Trim(),
                            numText2doDoc = line.Substring(691, 1).Trim(),
                            primerCortePar = line.Substring(692, 8).Trim(),
                            segundoCortePar = line.Substring(700, 8).Trim(),
                            tercerCortePar = line.Substring(708, 8).Trim(),
                            cuartoCortePar = line.Substring(716, 8).Trim(),
                            vigenciaEntrega = line.Substring(724, 8).Trim(),
                            text1erBimes = line.Substring(732, 30).Trim(),
                            text2doBimes = line.Substring(762, 30).Trim(),
                            text3erBimes = line.Substring(792, 30).Trim(),
                            text4toBimes = line.Substring(822, 30).Trim(),
                            text5toBimes = line.Substring(852, 30).Trim(),
                            text6toBimes = line.Substring(882, 30).Trim(),
                            fecha1erBimes = line.Substring(912, 40).Trim(),
                            fecha2doBimes = line.Substring(952, 40).Trim(),
                            fecha3erBimes = line.Substring(992, 40).Trim(),
                            fecha4toBimes = line.Substring(1032, 40).Trim(),
                            fecha5toBimes = line.Substring(1072, 40).Trim(),
                            fecha6toBimes = line.Substring(1112, 40).Trim(),
                            numSesion = line.Substring(1152, 10).Trim(),
                            consecutivoMedio = line.Substring(1162, 7).Trim(),
                            consecutivoKit = line.Substring(1169, 7).Trim(),
                            idEACP2 = line.Substring(1176, 4).Trim(),
                            idSucursal2 = line.Substring(1180, 5).Trim(),
                            idEntrega = line.Substring(1185, 1).Trim(),
                            claveDestino = line.Substring(1186, 9).Trim(),
                            descDestino = line.Substring(1195, 30).Trim(),
                            text7moBimes = line.Substring(1225, 30).Trim(),
                            fecha7moBimes = line.Substring(1255, 40).Trim(),
                            aperturaCtaId = line.Substring(1295, 9).Trim(),
                            programa = line.Substring(1304, 1).Trim(),
                            identImagen = line.Substring(1305, 4).Trim(),
                            tipoCuenta = line.Substring(1309, 1).Trim(),
                            numCuenta = line.Substring(1310, 10).Trim(),
                            tipoMovimiento = line.Substring(1320, 1).Trim(),
                            esquemaApoyo = line.Substring(1321, 1).Trim(),
                            PROIIF = line.Substring(1322, 1).Trim(),
                            canalPago = line.Substring(1323, 1).Trim(),
                            folioJap = line.Substring(1324, 12).Trim(),
                            #endregion
                        };

                    }
                    catch (Exception e)
                    {
                        //Crea una lista de la clase Archivo indicando que renglon tiene error y que error es
                        rowValue = new BeneficiarioEntity
                        {
                            IdRow = contador,
                            Message = e.Message
                        };
                    }
                    finally
                    {
                        //Agrega un nuevo row BeneficiarioEntity a la lista beneficiarioList
                        beneficiarioList.Add(rowValue);
                    }

                    contador++;
                }
                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error ----> : " + e.Message);
                result = false;
            }

            Console.WriteLine("End Load Data");

            return result;
        }

        internal bool ProcessFile()
        {
            bool result = false;

            try
            {
                Console.WriteLine("Start Process Data");
                string fileName = @"C:\Users\42039\Documents\Personal\myfile.txt";
                string fileNameError = @"C:\Users\42039\Documents\Personal\myfileError.txt";
                if (File.Exists(fileName))
                    File.Delete(fileName);
                if (File.Exists(fileNameError))
                    File.Delete(fileNameError);

                FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writerCorrect = new StreamWriter(fileStream);

                FileStream fileStreamError = new FileStream(fileNameError, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writerError = new StreamWriter(fileStreamError);

                foreach (var beneficiario in beneficiarioList)
                {
                    if (beneficiario.IsValidRow)
                    {
                        writerCorrect.WriteLine("{0,-7}{1,-9}{2,-9}{3,-2}{4,-21}{5,-6}{6,-3}{7,-50}{8,-4}{9,-50}{10,-7}",beneficiario.Remesa,beneficiario.idIntegrante,beneficiario.idFamilia,beneficiario.Estado,
                            beneficiario.descEdo, beneficiario.znaAtencion, beneficiario.idMunicipio, beneficiario.descMunicipio, beneficiario.idLocalidad, beneficiario.descLocalidad, beneficiario.idAGEB);
                    }
                    else
                        writerError.WriteLine("{0,-7}{1,-9}{2,-9}{3,-2}{4,-21}{5,-6}{6,-3}{7,-50}{8,-4}{9,-50}{10,-7}", beneficiario.Remesa, beneficiario.idIntegrante, beneficiario.idFamilia, beneficiario.Estado,
                            beneficiario.descEdo, beneficiario.znaAtencion, beneficiario.idMunicipio, beneficiario.descMunicipio, beneficiario.idLocalidad, beneficiario.descLocalidad, beneficiario.idAGEB);
                }
                writerCorrect.Close();
                writerError.Close();
                result = true;
                Console.WriteLine("End Process Data");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error ----> : " + e.Message);
            }


            return result;
        }

        internal bool ValidateFile()
        {
            var result = false;
            try
            {
                Console.WriteLine("Start Validate Data");

                var validation = new ValidationRules();
                foreach (var beneficiario in beneficiarioList)
                {
                    bool isValid = validation.ValidateBeneficiary(beneficiario);
                    beneficiario.IsValidRow = isValid;
                }
                result = true;
                Console.WriteLine("End Validate Data");

            }
            catch (Exception e)
            {
                //Falta ver que haras con el error, en caso de que exista
                Console.WriteLine("Error ----> : " + e.Message);
                result = false;
            }
            return result;
        }
    }
}
