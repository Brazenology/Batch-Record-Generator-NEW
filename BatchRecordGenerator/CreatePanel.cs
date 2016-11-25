using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BatchRecordGenerator
{
    public partial class CreatePanel : Form
    {

        //Global Variables
        int errorCount = 0;
        bool partDuplicates = false;
        bool vicDuplicates = false;
        bool qcDuplicates = false;
        string connString = "Data Source=PAPALOA;Initial Catalog=BatchRecordApp;Integrated Security=True";//path to database

        public CreatePanel()
        {
            InitializeComponent();
        }

        private void CreatePanel_Load(object sender, EventArgs e)
        {
            //Populates all dropdown menus
            populateDropDowns();

            //Set all error indicators (asterisks) to the colour red
            asterisk1.ForeColor = System.Drawing.Color.Red;
            asterisk2.ForeColor = System.Drawing.Color.Red;
            asterisk3.ForeColor = System.Drawing.Color.Red;
            asterisk4.ForeColor = System.Drawing.Color.Red;
            asterisk5.ForeColor = System.Drawing.Color.Red;
            asterisk6.ForeColor = System.Drawing.Color.Red;
            asterisk7.ForeColor = System.Drawing.Color.Red;
            asterisk8.ForeColor = System.Drawing.Color.Red;
            asterisk9.ForeColor = System.Drawing.Color.Red;
            asterisk10.ForeColor = System.Drawing.Color.Red;
            asterisk11.ForeColor = System.Drawing.Color.Red;
            asterisk12.ForeColor = System.Drawing.Color.Red;
            asterisk13.ForeColor = System.Drawing.Color.Red;
            asterisk14.ForeColor = System.Drawing.Color.Red;
            asterisk15.ForeColor = System.Drawing.Color.Red;
            asterisk16.ForeColor = System.Drawing.Color.Red;
            asterisk17.ForeColor = System.Drawing.Color.Red;
            asterisk18.ForeColor = System.Drawing.Color.Red;
            asterisk19.ForeColor = System.Drawing.Color.Red;
            asterisk20.ForeColor = System.Drawing.Color.Red;
            asterisk21.ForeColor = System.Drawing.Color.Red;
            asterisk22.ForeColor = System.Drawing.Color.Red;
            asterisk23.ForeColor = System.Drawing.Color.Red;
            asterisk24.ForeColor = System.Drawing.Color.Red;
            asterisk25.ForeColor = System.Drawing.Color.Red;
            asterisk26.ForeColor = System.Drawing.Color.Red;
            asterisk27.ForeColor = System.Drawing.Color.Red;
            asterisk28.ForeColor = System.Drawing.Color.Red;
            asterisk29.ForeColor = System.Drawing.Color.Red;
            asterisk30.ForeColor = System.Drawing.Color.Red;
            asterisk31.ForeColor = System.Drawing.Color.Red;
            asterisk32.ForeColor = System.Drawing.Color.Red;
            asterisk33.ForeColor = System.Drawing.Color.Red;
            asterisk34.ForeColor = System.Drawing.Color.Red;
            asterisk35.ForeColor = System.Drawing.Color.Red;
            asterisk36.ForeColor = System.Drawing.Color.Red;
            asterisk37.ForeColor = System.Drawing.Color.Red;
            asterisk38.ForeColor = System.Drawing.Color.Red;
            asterisk39.ForeColor = System.Drawing.Color.Red;
            asterisk40.ForeColor = System.Drawing.Color.Red;
            asterisk41.ForeColor = System.Drawing.Color.Red;
            asterisk42.ForeColor = System.Drawing.Color.Red;
            asterisk43.ForeColor = System.Drawing.Color.Red;
            asterisk44.ForeColor = System.Drawing.Color.Red;
            asterisk45.ForeColor = System.Drawing.Color.Red;
            asterisk46.ForeColor = System.Drawing.Color.Red;
            asterisk47.ForeColor = System.Drawing.Color.Red;
            asterisk48.ForeColor = System.Drawing.Color.Red;
            asterisk49.ForeColor = System.Drawing.Color.Red;
            asterisk50.ForeColor = System.Drawing.Color.Red;
            asterisk51.ForeColor = System.Drawing.Color.Red;
            asterisk52.ForeColor = System.Drawing.Color.Red;
            asterisk53.ForeColor = System.Drawing.Color.Red;
            asterisk54.ForeColor = System.Drawing.Color.Red;
            asterisk55.ForeColor = System.Drawing.Color.Red;
            asterisk56.ForeColor = System.Drawing.Color.Red;
            asterisk57.ForeColor = System.Drawing.Color.Red;
            asterisk58.ForeColor = System.Drawing.Color.Red;
            asterisk59.ForeColor = System.Drawing.Color.Red;
            asterisk60.ForeColor = System.Drawing.Color.Red;
            asterisk61.ForeColor = System.Drawing.Color.Red;

            //Set Set all error indicators (asterisks) to be invisible on form load
            asterisk1.Visible = false;
            asterisk2.Visible = false;
            asterisk3.Visible = false;
            asterisk4.Visible = false;
            asterisk5.Visible = false;
            asterisk6.Visible = false;
            asterisk7.Visible = false;
            asterisk8.Visible = false;
            asterisk9.Visible = false;
            asterisk10.Visible = false;
            asterisk11.Visible = false;
            asterisk12.Visible = false;
            asterisk13.Visible = false;
            asterisk14.Visible = false;
            asterisk15.Visible = false;
            asterisk16.Visible = false;
            asterisk17.Visible = false;
            asterisk18.Visible = false;
            asterisk19.Visible = false;
            asterisk20.Visible = false;
            asterisk21.Visible = false;
            asterisk22.Visible = false;
            asterisk23.Visible = false;
            asterisk24.Visible = false;
            asterisk25.Visible = false;
            asterisk26.Visible = false;
            asterisk27.Visible = false;
            asterisk28.Visible = false;
            asterisk29.Visible = false;
            asterisk30.Visible = false;
            asterisk31.Visible = false;
            asterisk32.Visible = false;
            asterisk33.Visible = false;
            asterisk34.Visible = false;
            asterisk35.Visible = false;
            asterisk36.Visible = false;
            asterisk37.Visible = false;
            asterisk38.Visible = false;
            asterisk39.Visible = false;
            asterisk40.Visible = false;
            asterisk41.Visible = false;
            asterisk42.Visible = false;
            asterisk43.Visible = false;
            asterisk44.Visible = false;
            asterisk45.Visible = false;
            asterisk46.Visible = false;
            asterisk47.Visible = false;
            asterisk48.Visible = false;
            asterisk49.Visible = false;
            asterisk50.Visible = false;
            asterisk51.Visible = false;
            asterisk52.Visible = false;
            asterisk53.Visible = false;
            asterisk54.Visible = false;
            asterisk55.Visible = false;
            asterisk56.Visible = false;
            asterisk57.Visible = false;
            asterisk58.Visible = false;
            asterisk59.Visible = false;
            asterisk60.Visible = false;
            asterisk61.Visible = false;
        }

        /********************Populates all combo boxes in the create panel*********************/
        private void populateDropDowns() {

            //SQL Connection
            SqlConnection conn = new SqlConnection(connString); //References the connString global variable

            //Query strings
            string partRefs = "SELECT partRefName FROM tblPartRef";
            string BOM = "SELECT partName FROM tblParts";
            string VIC = "SELECT vicID, vicDetails FROM tblVisInspectionCriteria WHERE vicID LIKE 'FL%' ORDER BY vicID ASC";
            string model = "SELECT modelName FROM tblModel";
            string hibar = "SELECT hibarSetting FROM tblHibarPump";
            string oragene = "SELECT orageneVol FROM tblOrageneVolumes";
            string sealingHeadT = "SELECT sealingHeadTemp FROM tblSealingHeadT";
            string sealingHeadD = "SELECT sealingHeadDwell FROM tblSealingHeadD";
            string airPressure = "SELECT airPressureAmount FROM tblAirPressure";
            string fillToHeight = "SELECT fillToHeight FROM tblFillToHeight";
            string tubeSym = "SELECT symbology FROM tblTubeSymbology";
            string tubeDecode = "SELECT decodability FROM tblTubeDecodability";
            string stabSol = "SELECT partNum FROM tblStabSol";
            string phv = "SELECT label FROM tblPrintHeadVerification";
            string manu = "SELECT manufacturer FROM tblManufacturingID";
            string fillToText = "SELECT fillToText FROM tblFillToText";
            string fillToUpper = "SELECT fillToUpper FROM tblFillToUpper";
            string UDIVer = "SELECT UDIVer FROM tblUDIVerification";
            string UDIgtin = "SELECT GTIN FROM tblUDIHumanReadGTIN";
            string fillToLower = "SELECT fillToLower FROM tblFillToLower";
            string humanReadBarcode = "SELECT readableBarcode FROM tblHumanReadBarcode";
            string labelStock = "SELECT labelDesign FROM tblLabelStockDesign";
            string randomField = "SELECT randomField FROM tblRandomField";
            string darkness = "SELECT darknessSetting FROM tblDarknessSetting";
            string visionCam = "SELECT visionCamera FROM tblVisionCamera";
            string QC = "SELECT vicID, vicDetails FROM tblVisInspectionCriteria ORDER BY vicID ASC";

            //SQL Commands
            SqlCommand populatePartRefs = new SqlCommand(partRefs, conn);
            SqlCommand populateBOM = new SqlCommand(BOM, conn);
            SqlCommand populateVIC = new SqlCommand(VIC, conn);
            SqlCommand populateModel = new SqlCommand(model, conn);
            SqlCommand populateHibar = new SqlCommand(hibar, conn);
            SqlCommand populateOragene= new SqlCommand(oragene, conn);
            SqlCommand populateSealingHeadT = new SqlCommand(sealingHeadT, conn);
            SqlCommand populateSealingHeadD = new SqlCommand(sealingHeadD, conn);
            SqlCommand populateAirPressure = new SqlCommand(airPressure, conn);
            SqlCommand populateFillToHeight = new SqlCommand(fillToHeight, conn);
            SqlCommand populateTubeSym = new SqlCommand(tubeSym, conn);
            SqlCommand populateTubeDecode = new SqlCommand(tubeDecode, conn);
            SqlCommand populateStabSol = new SqlCommand(stabSol, conn);
            SqlCommand populatePHV = new SqlCommand(phv, conn);
            SqlCommand populateManu = new SqlCommand(manu, conn);
            SqlCommand populateFtt = new SqlCommand(fillToText, conn);
            SqlCommand populateFtu = new SqlCommand(fillToUpper, conn);
            SqlCommand populateUDIVer = new SqlCommand(UDIVer, conn);
            SqlCommand populateGTIN = new SqlCommand(UDIgtin, conn);
            SqlCommand populateFtl = new SqlCommand(fillToLower, conn);
            SqlCommand populateHRB = new SqlCommand(humanReadBarcode, conn);
            SqlCommand populateLabelStock = new SqlCommand(labelStock, conn);
            SqlCommand populateRandomField = new SqlCommand(randomField, conn);
            SqlCommand populateDarknessSetting = new SqlCommand(darkness, conn);
            SqlCommand populateVisionCam = new SqlCommand(visionCam, conn);
            SqlCommand populateQC = new SqlCommand(QC, conn);

            //Data Tables
            DataTable partRefdt = new DataTable();
            DataTable BOMdt = new DataTable();
            DataTable VICdt = new DataTable();
            DataTable modeldt = new DataTable();
            DataTable hibardt = new DataTable();
            DataTable oragenedt = new DataTable();
            DataTable sealingHeadTdt = new DataTable();
            DataTable sealingHeadDdt = new DataTable();
            DataTable airPressuredt = new DataTable();
            DataTable fillToHeightdt = new DataTable();
            DataTable tubeSymdt = new DataTable();
            DataTable tubeDecodedt = new DataTable();
            DataTable stabSoldt = new DataTable();
            DataTable PHVdt = new DataTable();
            DataTable manudt = new DataTable();
            DataTable fillToTextdt = new DataTable();
            DataTable fillToUpperdt = new DataTable();
            DataTable UDIVerdt = new DataTable();
            DataTable UDIgtindt = new DataTable();
            DataTable fillToLowerdt = new DataTable();
            DataTable HRBdt = new DataTable();
            DataTable labelStockdt = new DataTable();
            DataTable randomFielddt = new DataTable();
            DataTable darknessSettingdt = new DataTable();
            DataTable visionCamdt = new DataTable();
            DataTable QCdt = new DataTable();

            //SQL Adapters
            SqlDataAdapter partRefda = new SqlDataAdapter(populatePartRefs);
            SqlDataAdapter BOMda = new SqlDataAdapter(populateBOM);
            SqlDataAdapter VICda = new SqlDataAdapter(populateVIC);
            SqlDataAdapter modelda = new SqlDataAdapter(populateModel);
            SqlDataAdapter hibarda = new SqlDataAdapter(populateHibar);
            SqlDataAdapter orageneda = new SqlDataAdapter(populateOragene);
            SqlDataAdapter sealingHeadTda = new SqlDataAdapter(populateSealingHeadT);
            SqlDataAdapter sealingHeadDda = new SqlDataAdapter(populateSealingHeadD);
            SqlDataAdapter airPressureda = new SqlDataAdapter(populateAirPressure);
            SqlDataAdapter fillToHeightda = new SqlDataAdapter(populateFillToHeight);
            SqlDataAdapter tubeSymda = new SqlDataAdapter(populateTubeSym);
            SqlDataAdapter tubeDecodeda = new SqlDataAdapter(populateTubeDecode);
            SqlDataAdapter stabSolda = new SqlDataAdapter(populateStabSol);
            SqlDataAdapter PHVda = new SqlDataAdapter(populatePHV);
            SqlDataAdapter manuda = new SqlDataAdapter(populateManu);
            SqlDataAdapter fttda = new SqlDataAdapter(populateFtt);
            SqlDataAdapter ftuda = new SqlDataAdapter(populateFtu);
            SqlDataAdapter UDIVerda = new SqlDataAdapter(populateUDIVer);
            SqlDataAdapter UDIgtinda = new SqlDataAdapter(populateGTIN);
            SqlDataAdapter ftlda = new SqlDataAdapter(populateFtl);
            SqlDataAdapter HRBda = new SqlDataAdapter(populateHRB);
            SqlDataAdapter labelStockda = new SqlDataAdapter(populateLabelStock);
            SqlDataAdapter randomFieldda = new SqlDataAdapter(populateRandomField);
            SqlDataAdapter darknessSettingda = new SqlDataAdapter(populateDarknessSetting);
            SqlDataAdapter visionCamda = new SqlDataAdapter(populateVisionCam);
            SqlDataAdapter QCda = new SqlDataAdapter(populateQC);


            try
            {
                conn.Open();

                //Executes the request to the database to grab all information to populate combo boxes.
                populateBOM.ExecuteNonQuery();
                populatePartRefs.ExecuteNonQuery();
                populateVIC.ExecuteNonQuery();
                populateModel.ExecuteNonQuery();
                populateHibar.ExecuteNonQuery();
                populateOragene.ExecuteNonQuery();
                populateSealingHeadT.ExecuteNonQuery();
                populateSealingHeadD.ExecuteNonQuery();
                populateAirPressure.ExecuteNonQuery();
                populateFillToHeight.ExecuteNonQuery();
                populateTubeSym.ExecuteNonQuery();
                populateTubeDecode.ExecuteNonQuery();
                populateStabSol.ExecuteNonQuery();
                populatePHV.ExecuteNonQuery();
                populateManu.ExecuteNonQuery();
                populateFtt.ExecuteNonQuery();
                populateFtu.ExecuteNonQuery();
                populateUDIVer.ExecuteNonQuery();
                populateGTIN.ExecuteNonQuery();
                populateFtl.ExecuteNonQuery();
                populateHRB.ExecuteNonQuery();
                populateLabelStock.ExecuteNonQuery();
                populateRandomField.ExecuteNonQuery();
                populateDarknessSetting.ExecuteNonQuery();
                populateVisionCam.ExecuteNonQuery();
                populateQC.ExecuteNonQuery();

                //Fills each datatable with its corresponding data
                BOMda.Fill(BOMdt);
                partRefda.Fill(partRefdt);
                VICda.Fill(VICdt);
                modelda.Fill(modeldt);
                hibarda.Fill(hibardt);
                orageneda.Fill(oragenedt);
                sealingHeadTda.Fill(sealingHeadTdt);
                sealingHeadDda.Fill(sealingHeadDdt);
                airPressureda.Fill(airPressuredt);
                fillToHeightda.Fill(fillToHeightdt);
                tubeSymda.Fill(tubeSymdt);
                tubeDecodeda.Fill(tubeDecodedt);
                stabSolda.Fill(stabSoldt);
                PHVda.Fill(PHVdt);
                manuda.Fill(manudt);
                fttda.Fill(fillToTextdt);
                ftuda.Fill(fillToUpperdt);
                UDIVerda.Fill(UDIVerdt);
                UDIgtinda.Fill(UDIgtindt);
                ftlda.Fill(fillToLowerdt);
                HRBda.Fill(HRBdt);
                labelStockda.Fill(labelStockdt);
                randomFieldda.Fill(randomFielddt);
                darknessSettingda.Fill(darknessSettingdt);
                visionCamda.Fill(visionCamdt);
                QCda.Fill(QCdt);


                foreach (DataRow dr in partRefdt.Rows)//Grabs all part reference names and inserts them in the part reference combo box
                {
                    partRefCombo.Items.Add(dr["partRefName"].ToString());
                }

                foreach (DataRow dr in BOMdt.Rows) //Grabs all the parts found and inserts them into each Part Name combo box
                {
                    part1ComboBox.Items.Add(dr["partName"].ToString());
                    part2ComboBox.Items.Add(dr["partName"].ToString());
                    part3ComboBox.Items.Add(dr["partName"].ToString());
                    part4ComboBox.Items.Add(dr["partName"].ToString());
                    part5ComboBox.Items.Add(dr["partName"].ToString());
                    part6ComboBox.Items.Add(dr["partName"].ToString());
                    part7ComboBox.Items.Add(dr["partName"].ToString());
                    part8ComboBox.Items.Add(dr["partName"].ToString());
                    part9ComboBox.Items.Add(dr["partName"].ToString());
                    part10ComboBox.Items.Add(dr["partName"].ToString());
                    part11ComboBox.Items.Add(dr["partName"].ToString());
                    part12ComboBox.Items.Add(dr["partName"].ToString());
                    part13ComboBox.Items.Add(dr["partName"].ToString());
                    part14ComboBox.Items.Add(dr["partName"].ToString());
                    part15ComboBox.Items.Add(dr["partName"].ToString());
                    part16ComboBox.Items.Add(dr["partName"].ToString());
                    part17ComboBox.Items.Add(dr["partName"].ToString());
                    part18ComboBox.Items.Add(dr["partName"].ToString());
                    part19ComboBox.Items.Add(dr["partName"].ToString());
                    part20ComboBox.Items.Add(dr["partName"].ToString());
                    part21ComboBox.Items.Add(dr["partName"].ToString());
                    part22ComboBox.Items.Add(dr["partName"].ToString());
                    part23ComboBox.Items.Add(dr["partName"].ToString());
                    part24ComboBox.Items.Add(dr["partName"].ToString());
                    part25ComboBox.Items.Add(dr["partName"].ToString());
                }

                foreach (DataRow dr in VICdt.Rows)//Grabs all part reference names and inserts them in the first-off/last-off inspection combo boxes
                {
                    visInspecCombo1.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo2.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo3.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo4.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo5.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo6.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo7.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo8.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo9.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo10.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo11.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo12.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo13.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo14.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo15.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo16.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo17.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo18.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo19.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo20.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo21.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo22.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo23.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo24.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    visInspecCombo25.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                }

                foreach (DataRow dr in modeldt.Rows)//Grabs all model names and inserts them in the model select combo box
                {
                    modelSelectCombo.Items.Add(dr["modelName"].ToString());
                }

                foreach (DataRow dr in hibardt.Rows)//Grabs all hibar pump settings and inserts them in the hibar pump combo box
                {
                    hibarPumpCombo.Items.Add(dr["hibarSetting"].ToString());
                }

                foreach (DataRow dr in oragenedt.Rows)//Grabs all oragene volumes and inserts them in the oragene volume combo box
                {
                    orageneCombo.Items.Add(dr["orageneVol"].ToString());
                }

                foreach (DataRow dr in sealingHeadTdt.Rows)//Grabs all sealing head temperatures and inserts them in the sealing Head Temp combo box
                {
                    sealingTempCombo.Items.Add(dr["sealingHeadTemp"].ToString());
                }

                foreach (DataRow dr in sealingHeadDdt.Rows)//Grabs all sealing head dwell times and inserts them in the sealing Dwell Temp combo box
                {
                    sealingDwellCombo.Items.Add(dr["sealingHeadDwell"].ToString());
                }

                foreach (DataRow dr in airPressuredt.Rows)//Grabs all air pressure amounts and inserts them in the air pressure combo box
                {
                    airPressureCombo.Items.Add(dr["airPressureAmount"].ToString());
                }

                foreach (DataRow dr in fillToHeightdt.Rows)//Grabs all fill to heights and inserts them in the fill to height combo box
                {
                    fillToCombo.Items.Add(dr["fillToHeight"].ToString());
                }

                foreach (DataRow dr in tubeSymdt.Rows)//Grabs all tube barcode symbology's and inserts them in the tube barcode symbology combo box
                {
                    tubeSymCombo.Items.Add(dr["symbology"].ToString());
                }


                foreach (DataRow dr in tubeDecodedt.Rows)//Grabs all tube barcode Decodabiliies and inserts them in the tube barcode decodability combo box
                {
                    tubeDecodeCombo.Items.Add(dr["decodability"].ToString());
                }
                
                foreach (DataRow dr in stabSoldt.Rows)//Grabs all stabilizing solution part numbers and inserts them in the stabilizing solution combo box
                {
                    stabSolCombo.Items.Add(dr["partNum"].ToString());
                }

                foreach (DataRow dr in PHVdt.Rows)//Grabs all labels and inserts them in the print head verification combo box
                {
                    phvCombo.Items.Add(dr["label"].ToString());
                }

                foreach (DataRow dr in manudt.Rows)//Grabs all manufacturer ID's and inserts them in the manufacturing ID combo box
                {
                    manuIDCombo.Items.Add(dr["manufacturer"].ToString());
                }

                foreach (DataRow dr in fillToTextdt.Rows)//Grabs all fill to text's and inserts them in the fill to text combo box
                {
                    fillToTextCombo.Items.Add(dr["fillToText"].ToString());
                }

                foreach (DataRow dr in fillToUpperdt.Rows)//Grabs all fill to upper's and inserts them in the fill to upper combo box
                {
                    fillToUpperCombo.Items.Add(dr["fillToUpper"].ToString());
                }

                foreach (DataRow dr in UDIVerdt.Rows)//Grabs all fill to upper's and inserts them in the UDI Barcode Verification combo box
                {
                    udiVerCombo.Items.Add(dr["UDIVer"].ToString());
                }

                foreach (DataRow dr in UDIgtindt.Rows)//Grabs all gtin's and inserts them in the UDI Human Readable GTIN combo box
                {
                    gtinCombo.Items.Add(dr["GTIN"].ToString());
                }

                foreach (DataRow dr in fillToLowerdt.Rows)//Grabs all fill to lowers and inserts them in the fill to lower combo box
                {
                    fillToLowerCombo.Items.Add(dr["fillToLower"].ToString());
                }

                foreach (DataRow dr in HRBdt.Rows)//Grabs all readable barcode and inserts them in the HRB combo box
                {
                    hrbCombo.Items.Add(dr["readableBarcode"].ToString());
                }

                foreach (DataRow dr in labelStockdt.Rows)//Grabs all label designs and inserts them in the label stock design combo box
                {
                    labelStockCombo.Items.Add(dr["labelDesign"].ToString());
                }

                foreach (DataRow dr in randomFielddt.Rows)//Grabs all random fields and inserts them in the random field combo box
                {
                    randomFieldCombo.Items.Add(dr["randomField"].ToString());
                }

                foreach (DataRow dr in darknessSettingdt.Rows)//Grabs all darkness settings and inserts them in the darkness setting combo box
                {
                    darknessCombo.Items.Add(dr["darknessSetting"].ToString());
                }

                foreach (DataRow dr in visionCamdt.Rows)//Grabs all darkness settings and inserts them in the darkness setting combo box
                {
                    visionCombo.Items.Add(dr["visionCamera"].ToString());
                }

                foreach (DataRow dr in QCdt.Rows)//Grabs all part reference names and inserts them in the Q/C Sample inspection criteria combo boxes
                {
                    QCSCrit1.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit2.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit3.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit4.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit5.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit6.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit7.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit8.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit9.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit10.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit11.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit12.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit13.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit14.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit15.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit16.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit17.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit18.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit19.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit20.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit21.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit22.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit23.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit24.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                    QCSCrit25.Items.Add(dr["vicID"].ToString() + ": " + dr["vicDetails"].ToString());
                }
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops! Can't seem to make a connection to the database right now. Please try again later. If the problem persists, please contact a system administrator.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        /********************Quick Links*************************/
        private void cancelRecordLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Cancels the batch record
            this.Close();
            HomePanel home = new HomePanel();
            home.Show();
        }
        /***********************END*****************************/

        private void CreatePanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Re-launches the home panel
            HomePanel home = new HomePanel();
            home.Show();
        }

        private void applyDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Allows user to apply a date to the label if the choose
            if (applyDateCheckBox.Checked)
            {
                labelDatePicker.Enabled = true;
            }
            else
            {
                labelDatePicker.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            //Allows user to access more fields if neccessary
            if (checkBox1.Checked)
            {
                addFieldCombo1.Enabled = true;
                addFieldCombo2.Enabled = true;
                addFieldCombo3.Enabled = true;
            }
            else
            {
                addFieldCombo1.Enabled = false;
                addFieldCombo2.Enabled = false;
                addFieldCombo3.Enabled = false;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //Draw a Grey border around the inside of the Panel.
            Rectangle rect = panel3.ClientRectangle;
            rect.Width--;
            rect.Height--;
            e.Graphics.DrawRectangle(Pens.Gray, rect);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (applyDateCheckBox.Checked)
            {
                labelDatePicker.Enabled = true;
            }
            else
            {
                labelDatePicker.Enabled = false;
            }
        }

        /************************* Navigation buttons (cycles through tabs)*************************/
        private void nextButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void nextButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void nextButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void nextButton4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void nextButton5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void nextButton6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void nextButton7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void nextButton8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            //Disabled
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void backButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void backButton4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void backButton5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void backButton6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void backButton7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void backButton8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void backButton9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        //******************************END***********************************//

        private void labelPreviewButton_Click(object sender, EventArgs e)
        {

            //Allows use of symbols in the labels
            pDocNumLabel.UseMnemonic = false;
            pCustNameLabel.UseMnemonic = false;
            pPartRefLabel.UseMnemonic = false;
            pPartDescLabel.UseMnemonic = false;


            //Sets the labels in the preview pane to be equal to their matching input fields
            if (!string.IsNullOrEmpty(docNumText.Text))
            {
                pDocNumLabel.Text = docNumText.Text;
            }
            else
            {
                pDocNumLabel.Text = "undefined";
            }
            //
            if (!string.IsNullOrEmpty(custNameText.Text))
            {
                pCustNameLabel.Text = custNameText.Text;
            }
            else
            {
                pCustNameLabel.Text = "undefined";
            }
            //
            if (!string.IsNullOrEmpty(partRefCombo.Text))
            {
                pPartRefLabel.Text = partRefCombo.Text;
            }
            else
            {
                pPartRefLabel.Text = "undefined";
            }
            //
            if (!string.IsNullOrEmpty(partDescText.Text))
            {
                pPartDescLabel.Text = partDescText.Text;
            }
            else
            {
                pPartDescLabel.Text = "undefined";
            }
            //
            if (!string.IsNullOrEmpty(revNumText.Text))
            {
                pRevNumLabel.Text = revNumText.Text;
            }
            else
            {
                pRevNumLabel.Text = "undefined";
            }
            //
            if (applyDateCheckBox.Checked)
            {
                pDateLabel.Text = labelDatePicker.Text;
            }
            else
            {
                pDateLabel.Text = "undefined";
            }

            //Makes the information in the preview pane visible
            pDocNumLabel.Visible = true;
            pCustNameLabel.Visible = true;
            pPartRefLabel.Visible = true;
            pPartDescLabel.Visible = true;
            pRevNumLabel.Visible = true;
            pDateLabel.Visible = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Makes the information in the preview pane no longer visible 
            pDocNumLabel.Visible = false;
            pCustNameLabel.Visible = false;
            pPartRefLabel.Visible = false;
            pPartDescLabel.Visible = false;
            pRevNumLabel.Visible = false;
            pDateLabel.Visible = false;

            //Resets the fields to undefined
            pDocNumLabel.Text = "undefined";
            pCustNameLabel.Text = "undefined";
            pPartRefLabel.Text = "undefined";
            pPartRefLabel.Text = "undefined";
            pPartDescLabel.Text = "undefined";
            pDateLabel.Text = "undefined";

        }


        private void part1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part1ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip1.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part2ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip2.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part3ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip3.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part4ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part4ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip4.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part5ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part5ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip5.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part6ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part6ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip6.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part7ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part7ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip7.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part8ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part8ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip8.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part9ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part9ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip9.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part10ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part10ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip10.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part11ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part11ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip11.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part12ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part12ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip12.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part13ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part13ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip13.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part14ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part14ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip14.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part15ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part15ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip15.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part16ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part16ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip16.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part17ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part17ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip17.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part18ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part18ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip18.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part19ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part19ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip19.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part20ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part20ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip20.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part21ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part21ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip21.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part22ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part22ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip22.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part23ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part23ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip23.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part24ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part24ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip24.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void part25ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString); //SQL Connection

            string descripSelect = "SELECT partDesc FROM tblParts WHERE partName = '" + part25ComboBox.Text + "'"; //Selects matching description for part
            SqlCommand populateDesc = new SqlCommand(descripSelect, conn);

            try
            {
                conn.Open();
                descrip25.Text = populateDesc.ExecuteScalar().ToString(); //Populates the textbox
                conn.Close();
            }
            catch (Exception ex) //Display a warning message if the description for the part cannot be found
            {
                MessageBox.Show("Description for this part cannot be found.", "Missing Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*
         *The finish button will first check all required input fields to ensure they have been filled out.
         *If a field has been let blank, the corresponding error indicator will appear and the user will be notified via pop-up box.
         *If there are no errors, the batch record is processed and inserted into the database.
        */
        private void finishButton_Click(object sender, EventArgs e)
        {
            partDuplicatesCheck(); //Checks for duplicate parts
            vicDuplicatesCheck(); //Checks for duplicate vic's in the first-off/last-off inspection tab
            qcDuplicatesCheck(); // Checks for duplicates vic's in the Q/C Sample tab
            requiredFieldsCheck(); //Checks for blank required fields

            if (partDuplicates == true)
            {
                MessageBox.Show("It appears you have duplicate parts in the Bill of Materials. Please review the 'BOM' tab and ensure you do not have duplicate entries.", "Duplicates Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (vicDuplicates == true)
            {
                MessageBox.Show("It appears you have duplicate entries in the First-Off/Last-Off Inspection. Please review the 'First-Off/Last-Off' tab and ensure you do not have duplicate entries.", "Duplicates Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (qcDuplicates == true)
            {
                MessageBox.Show("It appears you have duplicate entries in the Q/C Sample tab. Please review the 'Q/C Sample' tab and ensure you do not have duplicate entries.", "Duplicates Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (errorCount > 0)
            {
                MessageBox.Show("It appears you left " + errorCount + " required field(s) blank. Please check the information you provided and fill in all fields marked with a red asterisk(*).", "Missing Fields",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //insert into database
                MessageBox.Show("Success! Your batch record has been successfully processed.", "Batch Record Completed",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void partDuplicatesCheck()
        {
            partDuplicates = false;
            int partCount = 0;
            List<string> partNames = new List<string>();
            partNames.Clear();

            /*Add Parts to partNames Array if they are not blank*/
            if (!string.IsNullOrEmpty(part1ComboBox.Text))
            {
                partNames.Add(part1ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part2ComboBox.Text))
            {
                partNames.Add(part2ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part3ComboBox.Text))
            {
                partNames.Add(part3ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part4ComboBox.Text))
            {
                partNames.Add(part4ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part5ComboBox.Text))
            {
                partNames.Add(part5ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part6ComboBox.Text))
            {
                partNames.Add(part6ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part7ComboBox.Text))
            {
                partNames.Add(part7ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part8ComboBox.Text))
            {
                partNames.Add(part8ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part9ComboBox.Text))
            {
                partNames.Add(part9ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part10ComboBox.Text))
            {
                partNames.Add(part10ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part11ComboBox.Text))
            {
                partNames.Add(part11ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part12ComboBox.Text))
            {
                partNames.Add(part12ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part13ComboBox.Text))
            {
                partNames.Add(part13ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part14ComboBox.Text))
            {
                partNames.Add(part14ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part15ComboBox.Text))
            {
                partNames.Add(part15ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part16ComboBox.Text))
            {
                partNames.Add(part16ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part17ComboBox.Text))
            {
                partNames.Add(part17ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part18ComboBox.Text))
            {
                partNames.Add(part18ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part19ComboBox.Text))
            {
                partNames.Add(part19ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part20ComboBox.Text))
            {
                partNames.Add(part20ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part21ComboBox.Text))
            {
                partNames.Add(part21ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part22ComboBox.Text))
            {
                partNames.Add(part22ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part23ComboBox.Text))
            {
                partNames.Add(part23ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part24ComboBox.Text))
            {
                partNames.Add(part24ComboBox.Text);
            }
            //
            if (!string.IsNullOrEmpty(part25ComboBox.Text))
            {
                partNames.Add(part25ComboBox.Text);
            }

            partCount = partNames.Count(); // Counts the number of elements in the partNames List

            /* Loops through the List and checks for duplicates*/
            for (int i = 0; i < partCount; i++)
            {
                for (int z = 0; z < partCount; z++)
                {
                    if (partNames[i].Equals(partNames[z]))
                    {
                        if (i != z)
                        {
                            partDuplicates = true;
                        }
                    }
                }
            }
        }

        private void vicDuplicatesCheck()
        {
            vicDuplicates = false;
            int vicCount = 0;
            List<string> vicDesc = new List<string>();
            vicDesc.Clear();

            /*Add vic's to vicDesc Array if they are not blank*/
            if (!string.IsNullOrEmpty(visInspecCombo1.Text))
            {
                vicDesc.Add(visInspecCombo1.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo2.Text))
            {
                vicDesc.Add(visInspecCombo2.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo3.Text))
            {
                vicDesc.Add(visInspecCombo3.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo4.Text))
            {
                vicDesc.Add(visInspecCombo4.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo5.Text))
            {
                vicDesc.Add(visInspecCombo5.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo6.Text))
            {
                vicDesc.Add(visInspecCombo6.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo7.Text))
            {
                vicDesc.Add(visInspecCombo7.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo8.Text))
            {
                vicDesc.Add(visInspecCombo8.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo9.Text))
            {
                vicDesc.Add(visInspecCombo9.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo10.Text))
            {
                vicDesc.Add(visInspecCombo10.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo11.Text))
            {
                vicDesc.Add(visInspecCombo11.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo12.Text))
            {
                vicDesc.Add(visInspecCombo12.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo13.Text))
            {
                vicDesc.Add(visInspecCombo13.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo14.Text))
            {
                vicDesc.Add(visInspecCombo14.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo15.Text))
            {
                vicDesc.Add(visInspecCombo15.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo16.Text))
            {
                vicDesc.Add(visInspecCombo16.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo17.Text))
            {
                vicDesc.Add(visInspecCombo17.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo18.Text))
            {
                vicDesc.Add(visInspecCombo18.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo19.Text))
            {
                vicDesc.Add(visInspecCombo19.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo20.Text))
            {
                vicDesc.Add(visInspecCombo20.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo21.Text))
            {
                vicDesc.Add(visInspecCombo21.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo22.Text))
            {
                vicDesc.Add(visInspecCombo22.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo23.Text))
            {
                vicDesc.Add(visInspecCombo23.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo24.Text))
            {
                vicDesc.Add(visInspecCombo24.Text);
            }
            //
            if (!string.IsNullOrEmpty(visInspecCombo25.Text))
            {
                vicDesc.Add(visInspecCombo25.Text);
            }

            vicCount = vicDesc.Count(); // Counts the number of elements in the vicDesc List

            /* Loops through the List and checks for duplicates*/
            for (int i = 0; i < vicCount; i++)
            {
                for (int z = 0; z < vicCount; z++)
                {
                    if (vicDesc[i].Equals(vicDesc[z]))
                    {
                        if (i != z)
                        {
                            vicDuplicates = true;
                        }
                    }
                }
            }
        }

        private void qcDuplicatesCheck()
        {
            qcDuplicates = false;
            int qcCount = 0;
            List<string> qcDesc = new List<string>();
            qcDesc.Clear();

            /*Add vic's to the qcDesc Array if they are not blank*/
            if (!string.IsNullOrEmpty(QCSCrit1.Text))
            {
                qcDesc.Add(QCSCrit1.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit2.Text))
            {
                qcDesc.Add(QCSCrit2.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit3.Text))
            {
                qcDesc.Add(QCSCrit3.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit4.Text))
            {
                qcDesc.Add(QCSCrit4.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit5.Text))
            {
                qcDesc.Add(QCSCrit5.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit6.Text))
            {
                qcDesc.Add(QCSCrit6.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit7.Text))
            {
                qcDesc.Add(QCSCrit7.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit8.Text))
            {
                qcDesc.Add(QCSCrit8.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit9.Text))
            {
                qcDesc.Add(QCSCrit9.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit10.Text))
            {
                qcDesc.Add(QCSCrit10.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit11.Text))
            {
                qcDesc.Add(QCSCrit11.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit12.Text))
            {
                qcDesc.Add(QCSCrit12.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit13.Text))
            {
                qcDesc.Add(QCSCrit13.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit14.Text))
            {
                qcDesc.Add(QCSCrit14.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit15.Text))
            {
                qcDesc.Add(QCSCrit15.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit16.Text))
            {
                qcDesc.Add(QCSCrit16.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit17.Text))
            {
                qcDesc.Add(QCSCrit17.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit18.Text))
            {
                qcDesc.Add(QCSCrit18.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit19.Text))
            {
                qcDesc.Add(QCSCrit19.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit20.Text))
            {
                qcDesc.Add(QCSCrit20.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit21.Text))
            {
                qcDesc.Add(QCSCrit21.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit22.Text))
            {
                qcDesc.Add(QCSCrit22.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit23.Text))
            {
                qcDesc.Add(QCSCrit23.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit24.Text))
            {
                qcDesc.Add(QCSCrit24.Text);
            }
            //
            if (!string.IsNullOrEmpty(QCSCrit25.Text))
            {
                qcDesc.Add(QCSCrit25.Text);
            }

            qcCount = qcDesc.Count(); // Counts the number of elements in the qcDesc List

            /* Loops through the List and checks for duplicates*/
            for (int i = 0; i < qcCount; i++)
            {
                for (int z = 0; z < qcCount; z++)
                {
                    if (qcDesc[i].Equals(qcDesc[z]))
                    {
                        if (i != z)
                        {
                            qcDuplicates = true;
                        }
                    }
                }
            }
        }


        private void requiredFieldsCheck()
        {
            errorCount = 0; //Counts how many errors were found
           
            //Document Number Field
            if (string.IsNullOrEmpty(docNumText.Text))
            {
                asterisk1.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk1.Visible = false;
            }

            //Customer Name Field
            if (string.IsNullOrEmpty(custNameText.Text))
            {
                asterisk2.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk2.Visible = false;
            }

            //Part Reference Field
            if (string.IsNullOrEmpty(partRefCombo.Text))
            {
                asterisk3.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk3.Visible = false;
            }

            //Part Description Field
            if (string.IsNullOrEmpty(partDescText.Text))
            {
                asterisk4.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk4.Visible = false;
            }

            //Revision Number Field
            if (string.IsNullOrEmpty(revNumText.Text))
            {
                asterisk5.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk5.Visible = false;
            }

            //BOM Field 1
            if (!string.IsNullOrEmpty(part1ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText1.Text))
            {
                asterisk6.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part1ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText1.Text))
            {
                asterisk6.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk6.Visible = false;
            }


            //BOM Field 2
            if (!string.IsNullOrEmpty(part2ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText2.Text))
            {
                asterisk7.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part2ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText2.Text))
            {
                asterisk7.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk7.Visible = false;
            }

            //BOM Field 3
            if (!string.IsNullOrEmpty(part3ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText3.Text))
            {
                asterisk8.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part3ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText3.Text))
            {
                asterisk8.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk8.Visible = false;
            }

            //BOM Field 4
            if (!string.IsNullOrEmpty(part4ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText4.Text))
            {
                asterisk9.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part4ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText4.Text))
            {
                asterisk9.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk9.Visible = false;
            }

            //BOM Field 5
            if (!string.IsNullOrEmpty(part5ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText5.Text))
            {
                asterisk10.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part5ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText5.Text))
            {
                asterisk10.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk10.Visible = false;
            }

            //BOM Field 6
            if (!string.IsNullOrEmpty(part6ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText6.Text))
            {
                asterisk11.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part6ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText6.Text))
            {
                asterisk11.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk11.Visible = false;
            }

            //BOM Field 7
            if (!string.IsNullOrEmpty(part7ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText7.Text))
            {
                asterisk12.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part7ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText7.Text))
            {
                asterisk12.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk12.Visible = false;
            }

            //BOM Field 8
            if (!string.IsNullOrEmpty(part8ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText8.Text))
            {
                asterisk13.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part8ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText8.Text))
            {
                asterisk13.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk13.Visible = false;
            }

            //BOM Field 9
            if (!string.IsNullOrEmpty(part9ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText9.Text))
            {
                asterisk14.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part9ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText9.Text))
            {
                asterisk14.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk14.Visible = false;
            }

            //BOM Field 10
            if (!string.IsNullOrEmpty(part10ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText10.Text))
            {
                asterisk15.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part10ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText10.Text))
            {
                asterisk15.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk15.Visible = false;
            }

            //BOM Field 11
            if (!string.IsNullOrEmpty(part11ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText11.Text))
            {
                asterisk16.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part11ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText11.Text))
            {
                asterisk16.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk16.Visible = false;
            }

            //BOM Field 12
            if (!string.IsNullOrEmpty(part12ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText12.Text))
            {
                asterisk17.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part12ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText12.Text))
            {
                asterisk17.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk17.Visible = false;
            }

            //BOM Field 13
            if (!string.IsNullOrEmpty(part13ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText13.Text))
            {
                asterisk18.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part13ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText13.Text))
            {
                asterisk18.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk18.Visible = false;
            }

            //BOM Field 14
            if (!string.IsNullOrEmpty(part14ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText14.Text))
            {
                asterisk19.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part14ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText14.Text))
            {
                asterisk19.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk19.Visible = false;
            }

            //BOM Field 15
            if (!string.IsNullOrEmpty(part15ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText15.Text))
            {
                asterisk20.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part15ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText15.Text))
            {
                asterisk20.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk20.Visible = false;
            }

            //BOM Field 16
            if (!string.IsNullOrEmpty(part16ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText16.Text))
            {
                asterisk21.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part16ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText16.Text))
            {
                asterisk21.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk21.Visible = false;
            }

            //BOM Field 17
            if (!string.IsNullOrEmpty(part17ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText17.Text))
            {
                asterisk22.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part17ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText17.Text))
            {
                asterisk22.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk22.Visible = false;
            }

            //BOM Field 18
            if (!string.IsNullOrEmpty(part18ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText18.Text))
            {
                asterisk23.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part18ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText18.Text))
            {
                asterisk23.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk23.Visible = false;
            }

            //BOM Field 19
            if (!string.IsNullOrEmpty(part19ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText19.Text))
            {
                asterisk24.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part19ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText19.Text))
            {
                asterisk24.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk24.Visible = false;
            }

            //BOM Field 20
            if (!string.IsNullOrEmpty(part20ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText20.Text))
            {
                asterisk25.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part20ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText20.Text))
            {
                asterisk25.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk25.Visible = false;
            }

            //BOM Field 21
            if (!string.IsNullOrEmpty(part21ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText21.Text))
            {
                asterisk26.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part21ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText21.Text))
            {
                asterisk26.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk26.Visible = false;
            }

            //BOM Field 22
            if (!string.IsNullOrEmpty(part22ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText22.Text))
            {
                asterisk27.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part22ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText22.Text))
            {
                asterisk27.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk27.Visible = false;
            }

            //BOM Field 23
            if (!string.IsNullOrEmpty(part23ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText23.Text))
            {
                asterisk28.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part23ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText23.Text))
            {
                asterisk28.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk28.Visible = false;
            }

            //BOM Field 24
            if (!string.IsNullOrEmpty(part24ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText24.Text))
            {
                asterisk29.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part24ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText24.Text))
            {
                asterisk29.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk29.Visible = false;
            }

            //BOM Field 25
            if (!string.IsNullOrEmpty(part25ComboBox.Text.Trim()) && string.IsNullOrEmpty(quantityText25.Text))
            {
                asterisk30.Visible = true;
                errorCount++;
            }
            else if (string.IsNullOrEmpty(part25ComboBox.Text.Trim()) && !string.IsNullOrEmpty(quantityText25.Text))
            {
                asterisk30.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk30.Visible = false;
            }

            //Model Select Field
            if (string.IsNullOrEmpty(modelSelectCombo.Text.Trim()))
            {
                asterisk31.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk31.Visible = false;
            }

            //Barcode Scan Program Field
            if (string.IsNullOrEmpty(barcodeScanCombo.Text.Trim()))
            {
                asterisk32.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk32.Visible = false;
            }

            //Hibar Pump Field
            if (string.IsNullOrEmpty(hibarPumpCombo.Text.Trim()))
            {
                asterisk33.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk33.Visible = false;
            }

            //Oragene Volume Field
            if (string.IsNullOrEmpty(orageneCombo.Text.Trim()))
            {
                asterisk34.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk34.Visible = false;
            }

            //Sealing Head Temp Field
            if (string.IsNullOrEmpty(sealingTempCombo.Text.Trim()))
            {
                asterisk35.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk35.Visible = false;
            }

            //Sealing Head Dwell Field
            if (string.IsNullOrEmpty(sealingDwellCombo.Text.Trim()))
            {
                asterisk36.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk36.Visible = false;
            }

            //Air Pressure Field
            if (string.IsNullOrEmpty(airPressureCombo.Text.Trim()))
            {
                asterisk37.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk37.Visible = false;
            }

            //Fill To Height Field
            if (string.IsNullOrEmpty(fillToCombo.Text.Trim()))
            {
                asterisk38.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk38.Visible = false;
            }

            //Tube Barcode Symbology Field
            if (string.IsNullOrEmpty(tubeSymCombo.Text.Trim()))
            {
                asterisk39.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk39.Visible = false;
            }

            //Tube Barcode Decodability Field
            if (string.IsNullOrEmpty(tubeDecodeCombo.Text.Trim()))
            {
                asterisk40.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk40.Visible = false;
            }

            //Stabilizing Solution Field
            if (string.IsNullOrEmpty(stabSolCombo.Text.Trim()))
            {
                asterisk41.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk41.Visible = false;
            }

            //Print Head verificaition Field
            if (string.IsNullOrEmpty(phvCombo.Text.Trim()))
            {
                asterisk42.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk42.Visible = false;
            }

            //Barcode Identification Field
            if (string.IsNullOrEmpty(barcodeIDCombo.Text.Trim()))
            {
                asterisk43.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk43.Visible = false;
            }

            //Manufacturer Identification Field
            if (string.IsNullOrEmpty(manuIDCombo.Text.Trim()))
            {
                asterisk44.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk44.Visible = false;
            }

            //Fill To Line Text Field
            if (string.IsNullOrEmpty(fillToTextCombo.Text.Trim()))
            {
                asterisk45.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk45.Visible = false;
            }

            //Fill To Upper Field
            if (string.IsNullOrEmpty(fillToUpperCombo.Text.Trim()))
            {
                asterisk46.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk46.Visible = false;
            }

            //UDI Barcode Requirement Field
            if (string.IsNullOrEmpty(udiReqCombo.Text.Trim()))
            {
                asterisk47.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk47.Visible = false;
            }

            //UDI Barcode Verification Field
            if (string.IsNullOrEmpty(udiVerCombo.Text.Trim()))
            {
                asterisk48.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk48.Visible = false;
            }

            //UDI Human Readable GTIN Field
            if (string.IsNullOrEmpty(gtinCombo.Text.Trim()))
            {
                asterisk49.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk49.Visible = false;
            }

            //Label Identification Number Field
            if (string.IsNullOrEmpty(labelIDCombo.Text.Trim()))
            {
                asterisk50.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk50.Visible = false;
            }

            //Fill To Lower Field
            if (string.IsNullOrEmpty(fillToLowerCombo.Text.Trim()))
            {
                asterisk51.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk51.Visible = false;
            }

            //Lot Number Field
            if (string.IsNullOrEmpty(lotNumCombo.Text.Trim()))
            {
                asterisk52.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk52.Visible = false;
            }

            //Collect Saliva By Date Field
            if (string.IsNullOrEmpty(collectSalDatePicker.Text.Trim()))
            {
                asterisk53.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk53.Visible = false;
            }

            //Human Readable Barcode Field
            if (string.IsNullOrEmpty(hrbCombo.Text.Trim()))
            {
                asterisk54.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk54.Visible = false;
            }

            //Label Stock Design Field
            if (string.IsNullOrEmpty(labelStockCombo.Text.Trim()))
            {
                asterisk55.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk55.Visible = false;
            }


            //Random Field
            if (string.IsNullOrEmpty(randomFieldCombo.Text.Trim()))
            {
                asterisk56.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk56.Visible = false;
            }


            //Darkness Setting Field
            if (string.IsNullOrEmpty(darknessCombo.Text.Trim()))
            {
                asterisk57.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk57.Visible = false;
            }


            //Vision Camera Field
            if (string.IsNullOrEmpty(visionCombo.Text.Trim()))
            {
                asterisk58.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk58.Visible = false;
            }

            //Weigh Scale Procedure Radio Button Check
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton5.Checked)
            {
                asterisk59.Visible = false;
            }
            else
            {
                asterisk59.Visible = true;
                errorCount++;
            }

            //Ship ID Text Field
            if (string.IsNullOrEmpty(shipIDText.Text))
            {
                asterisk60.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk60.Visible = false;
            }

            //Mailer Box Label Field
            if (string.IsNullOrEmpty(mailerBoxText.Text))
            {
                asterisk61.Visible = true;
                errorCount++;
            }
            else
            {
                asterisk61.Visible = false;
            }
        }

        //Automatically selects the corresponding weigh scale procedure volume when selecting from the oragene volume combo box
        private void orageneCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orageneSelect = orageneCombo.Text;
            switch (orageneSelect)
            {
                case "0.75 mL":
                    radioButton1.Checked = true;
                    break;
                case "0.95 mL":
                    radioButton2.Checked = true;
                    break;
                case "1.1 mL":
                    radioButton5.Checked = true;
                    break;
                case "2.1 mL":
                    radioButton3.Checked = true;
                    break;
            }
        }
    }
}
