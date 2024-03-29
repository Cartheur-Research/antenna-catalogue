using System;
using System.Windows.Forms;
using CircuitCalculator;

namespace AntennaCatalog.Forms
{
    public partial class MagneticFieldCalculator : Form
    {
        private Form owner;
        private static bool instance = false;
        double result = 0;
        double axialLengthResult = 0;

        public MagneticFieldCalculator(Form mOwner)
        {
            InitializeComponent();
            fcCurrentFactor.Text = "A";
            fcRadiusFactor.Text = "cm";
            axialLengthFactor.Text = "cm";
            resultUnit.Text = "Gauss";
            axialLengthUnit.Text = "Gauss";
            owner = mOwner;
            //relativePermeabilityMediumTextBox.Text = "4π * 10E-7";//12.56637E-7
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
            //sessionValue.Text = (string)AppDomain.CurrentDomain.GetData("SessionID");
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 400;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.hLoopCenterPictureBox, "In this special case the symmetry is such that the field contributions " +
                "of all the current elements around the circumference add directly at the center. The line integral of the length is " +
                "just the circumference of the circle.");
            toolTip.SetToolTip(this.currentElementEquationBox, "The form of the magnetic field from a current element in the Biot-Savart law " +
                "in this case simplifies greatly because the angle equals 90 degrees for all points along the path and the distance to the field " +
                "point is constant. As such, it can be transposed into its integral form.");
        }

        public MagneticFieldCalculator()
        {
            InitializeComponent();
            fcCurrentFactor.Text = "A";
            fcRadiusFactor.Text = "cm";
            axialLengthFactor.Text = "cm";
            resultUnit.Text = "Gauss";
            axialLengthUnit.Text = "Gauss";
            
            //relativePermeabilityMediumTextBox.Text = "4π * 10E-7";//12.56637E-7
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
            //sessionValue.Text = (string)AppDomain.CurrentDomain.GetData("SessionID");
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 400;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.hLoopCenterPictureBox, "In this special case the symmetry is such that the field contributions " +
                "of all the current elements around the circumference add directly at the center. The line integral of the length is " +
                "just the circumference of the circle.");
            toolTip.SetToolTip(this.currentElementEquationBox, "The form of the magnetic field from a current element in the Biot-Savart law " +
                "in this case simplifies greatly because the angle equals 90 degrees for all points along the path and the distance to the field " +
                "point is constant. As such, it can be transposed into its integral form.");
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            instance = false;
            Close();
        }
        /// <summary>
        /// Calculate the Field at Center Current Loop equation.
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            CalculateResult();
            // Check for null entry.
        }
        /// <summary>
        /// Calculate the field at center of current loop.
        /// </summary>
        protected double CalculateResult()
        {
            //double result = 0;
            //double axialLengthResult = 0;
            double current = 0;
            double radius = 0;
            double axialLength = 0;

            double tempCurrent = Convert.ToDouble(fcCurrentValueBox.Text);
            double tempRadius = Convert.ToDouble(fcRadiusValueBox.Text);
            double tempAxialLength = Convert.ToDouble(axialLengthValueBox.Text);

            if (fcCurrentFactor.Text == "A")
            {
                current = tempCurrent * 1;
            }
            if (fcCurrentFactor.Text == "mA")
            {
                current = tempCurrent * 1E-3;
            }
            if (fcCurrentFactor.Text == "uA")
            {
                current = tempCurrent * 1E-6;
            }
            if (fcRadiusFactor.Text == "m")
            {
                radius = tempRadius * 1;
            }
            if (fcRadiusFactor.Text == "cm")
            {
                radius = tempRadius * 1E-2;
            }
            if (fcRadiusFactor.Text == "mm")
            {
                radius = tempRadius * 1E-3;
            }
            if (axialLengthFactor.Text == "m")
            {
                axialLength = tempAxialLength * 1;
            }
            if (axialLengthFactor.Text == "cm")
            {
                axialLength = tempAxialLength * 1E-2;
            }
            if (axialLengthFactor.Text == "mm")
            {
                axialLength = tempAxialLength * 1E-3;
            }
            // Calcualte the result
            double mu = 12.56637E-7;
            result = ((mu * current) / (2 * radius)) * 1E4;
            resultBox.Text = result.ToString();
            resultUnit.Text = "Gauss";
            // Calculate the axial length result
            axialLengthResult = ((mu / (4 * Math.PI)) * ((2 * Math.PI) * (radius * radius) * current) / Math.Pow(((axialLength * axialLength) + (radius * radius)), 1.5)) * 1E4;
            axialLengthResultBox.Text = axialLengthResult.ToString();
            axialLengthUnit.Text = "Gauss";

            return result;
            
        }
        /// <summary>
        /// Shows the geometry of the model.
        /// </summary>
        private void viewGeometryButton_Click(object sender, EventArgs e)
        {
            if (GeometryCircularLoop.Instance == false)
            {
                GeometryCircularLoop form = new GeometryCircularLoop(this);
                form.Show(this);
                GeometryCircularLoop.Instance = true;
            }
            else if (GeometryCircularLoop.Instance == true)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Sets the unit for the result box.
        /// </summary>
        private void resultUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (resultUnit.Text == "Gauss")
            //{
            //    double gaussResult = result * 1E4;
            //    resultBox.Text = gaussResult.ToString();
            //}
            if (resultUnit.Text == "T")
            {
                double gaussResult = result * 1e-4;
                resultBox.Text = gaussResult.ToString();
            }
        }
        /// <summary>
        /// Sets the unit for the axial length result box.
        /// </summary>
        private void axialLengthUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (axialLengthUnit.Text == "Gauss")
            //{
            //    double axialLengthGaussResult = axialLengthResult * 1E4;
            //    axialLengthResultBox.Text = axialLengthGaussResult.ToString();
            //}
            if (axialLengthUnit.Text == "T")
            {
                double axialLengthGaussResult = axialLengthResult * 1E-4;
                axialLengthResultBox.Text = axialLengthGaussResult.ToString();
            }
        }
        /// <summary>
        /// Opens the coil rotation calculator.
        /// </summary>
        private void rotationButton_Click(object sender, EventArgs e)
        {
            if (MagneticFieldCoilRotationCalculator.Instance == false)
            {
                MagneticFieldCoilRotationCalculator form = new MagneticFieldCoilRotationCalculator(this);
                form.Show(this);
                MagneticFieldCoilRotationCalculator.Instance = true;
            }
            else if (MagneticFieldCoilRotationCalculator.Instance == true)
            {
                // Do nothing.
            }
        }

    }
}
