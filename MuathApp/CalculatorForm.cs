using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Text.RegularExpressions;

using SuperControls;
using System.Globalization;
using System.Threading;

namespace SmartCalculator
{
    public partial class MainForm : Form
    {    
        // API
        public readonly string[] AppliedOperations = new string[] { "+", "-", "×", "÷", "^", "√" };

        public static readonly Color MainBoardColor = SystemColors.InactiveCaption;

        // API
        /// <summary>
        /// Menu open and close time In millieseconds
        /// </summary>
        public int MenuSpeed = 130;

        // Check variables:
        protected bool ApplyDot = true;
        protected bool ApplyOperation = false;
        protected bool ApplyMinus = true;

        // API
        protected decimal ANS = 0;

        private bool allowHexadecimal = false;
        public bool AllowHexadecimal 
        {
            get { return allowHexadecimal; }
            set 
            { 
                allowHexadecimal = value;
                HexadecimalPanel.Visible = value;
                SetButtonsEnabled(true);
            }
        }

        private CalculatorMode currentMode = CalculatorMode.Default;
        public CalculatorMode CurrentMode 
        { 
            get { return currentMode; }
            set 
            {
                currentMode = value;
                switch (currentMode)
                {
                    case CalculatorMode.Default:
                        UpPanel.Visible = true;
                        VariablesPanel.Visible = true;

                        PiButton.Visible = true;

                        DefaultOperationsPanel.Visible = true;

                        AllowHexadecimal = false;
                        ButtonNumber9.Enabled = true;
                        ButtonNumber8.Enabled = true;
                        ButtonNumber7.Enabled = true;
                        ButtonNumber6.Enabled = true;
                        ButtonNumber5.Enabled = true;
                        ButtonNumber4.Enabled = true;
                        ButtonNumber3.Enabled = true;
                        ButtonNumber2.Enabled = true;

                        ConversionPanel.Visible = false;

                        ANSButton.Visible = true;

                        EqualsButton.Size = new Size(192, EqualsButton.Height);
                        EqualsButton.Location = new Point(217, 421);
                        break;

                    case CalculatorMode.Developer:
                        UpPanel.Visible = false;
                        VariablesPanel.Visible = false;

                        PiButton.Visible = false;

                        DefaultOperationsPanel.Visible = false;

                        ConversionPanel.Visible = true;

                        ANSButton.Visible = false;

                        EqualsButton.Size = new Size(291, EqualsButton.Height);
                        EqualsButton.Location = new Point(118, 421);
                        break;

                    case CalculatorMode.Degrees:
                        UpPanel.Visible = false;
                        VariablesPanel.Visible = false;

                        PiButton.Visible = false;

                        DefaultOperationsPanel.Visible = false;

                        ConversionPanel.Visible = true;

                        AllowHexadecimal = false;
                        ButtonNumber9.Enabled = true;
                        ButtonNumber8.Enabled = true;
                        ButtonNumber7.Enabled = true;
                        ButtonNumber6.Enabled = true;
                        ButtonNumber5.Enabled = true;
                        ButtonNumber4.Enabled = true;
                        ButtonNumber3.Enabled = true;
                        ButtonNumber2.Enabled = true;

                        ANSButton.Visible = false;

                        EqualsButton.Size = new Size(291, EqualsButton.Height);
                        EqualsButton.Location = new Point(118, 421);
                        break;

                    default:
                        Error.ThrowError(ApplicationErrors.UnknownError);
                        return;
                }
                OnCurrentModeChanged(EventArgs.Empty);
            }
        }

        public event EventHandler CurrentModeChanged;

        private ApplicationErrors? currentError = null;
        public ApplicationErrors? CurrentError
        {
            get { return currentError; }
            set 
            {
                currentError = value;

            }
        }

        

        protected AnimationFlags OpenFlags;
        protected AnimationFlags CloseFlags;

        private bool isMenuOpened = false;
        public bool IsMenuOpened 
        {
            get 
            {
                return isMenuOpened;
            }
            private set
            {
                if (value == isMenuOpened) return;
                
                isMenuOpened = value;

                if (isMenuOpened)
                {
                    MenuItemsPanel.AnimateWindow(OpenFlags, MenuSpeed);
                }
                else
                {
                    MenuItemsPanel.AnimateWindow(CloseFlags, MenuSpeed);
                }
            }
        }

        // API
        public string MathExeprission
        {
            get { return MathExeprissionLabel.Text; }
            set
            {
                if (MathExepressionRichTextBox.Text == value.Remove(MathExepressionRichTextBox.Text.Length, value.Length - MathExepressionRichTextBox.Text.Length))
                {
                    MathExepressionRichTextBox.Text += value;
                    if (IsInsidePower)
                    {
                        MathExepressionRichTextBox.SelectedText = value;
                        MathExepressionRichTextBox.SelectionCharOffset = 44;
                        MathExepressionRichTextBox.SelectionFont = new Font(MathExepressionRichTextBox.Font.FontFamily, 8);
                    }
                }
                //MathExeprissionLabel.Text = value;
            }
        }

        private bool isInsidePower;

        public bool IsInsidePower
        {
            get { return isInsidePower; }
            set 
            { 
                isInsidePower = value;
                if (value)
                {
                    PowerButton.BackColor = SystemColors.Highlight;
                    PowerButton.ForeColor = SystemColors.HighlightText;
                }
                else
                {
                    PowerButton.BackColor = SystemColors.ScrollBar;
                    PowerButton.ForeColor = SystemColors.ControlText;
                }
            }
        }


        // API
        public decimal? Result
        {
            get 
            {
                try { return decimal.Parse(ResultLabel.Text); }
                catch { return null; }
            }
            set { ResultLabel.Text = value.ToString(); }
        }

        public MainForm()
        {
            Initialize();
        }

        public MainForm(string[] args)
        {
            Initialize();
            string mathEx = args.AsLines().Minmize();
            if (IsValidMathEx(mathEx))
            {
                MathExeprission = mathEx;
            }
        }

        public void Initialize()
        {
            InitializeComponent();
            RefreshMenu();

            CurrentModeComboBox.SelectedIndex = 0;
            FromComboBox.SelectedIndex = 0;
            ToComboBox.SelectedIndex = 1;
        }

        public bool IsValidMathEx(string mathEx)
        {
            return Regex.IsMatch(mathEx, @"^([-+/*]\d+(\.\d+)?)*", RegexOptions.Singleline);
        }

        #region Events

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateNumbers();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
            ApplyMinus = true;
            ApplyOperation = false;
            ApplyDot = true;
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            PerformBackspace();
        }

        protected void PerformBackspace()
        {
            if (MathExeprission == "")
            {
                return;
            }

            if (MathExeprission[MathExeprission.Length - 1] == ' ')
            {
                MathExeprission = MathExeprission.RemoveLastChar();
            }
            MathExeprission = MathExeprission.RemoveLastChar();
            ClearResult();
        }

        protected virtual void OnCurrentModeChanged(EventArgs args)
        {
            if (ConversionPanel.Visible == true)
            {
                string[] items = CurrentMode switch
                {
                    CalculatorMode.Developer => new string[4]
                            {
                            Texts.GetString("BIN"),
                            Texts.GetString("OCT"),
                            Texts.GetString("DEC"),
                            Texts.GetString("HEX")
                            },
                    CalculatorMode.Degrees => new string[3]
                            {
                            Texts.GetString("Celsius"),
                            Texts.GetString("Fahrenheit"),
                            Texts.GetString("Kelvin")
                            },
                    _ => throw new InvalidEnumArgumentException(nameof(CurrentMode), 0, typeof(CalculatorMode)),
                };
                FromComboBox.Items.Clear();
                FromComboBox.Items.AddRange(items);
                FromComboBox.SelectedIndex = 0;

                ToComboBox.Items.Clear();
                ToComboBox.Items.AddRange(items);
                ToComboBox.SelectedIndex = 1;
            }
            
            EventHandler handler = CurrentModeChanged;
            handler?.Invoke(this, args);
        }

        private void MathExeprissionLabel_TextChanged(object sender, EventArgs e)
        {
            if (Result is null)
            {
                ClearResult();
            }

            if (string.IsNullOrWhiteSpace(MathExeprission))
            {
                BackspaceButton.Visible = false;
                return;
            }
            BackspaceButton.Visible = true;
        }

        private void VariablesButton_Click(object sender, EventArgs e)
        {
            VariablesForm vf = new VariablesForm();
            vf.ShowDialog(this);
        }

        private void InsertVariableButton_Click(object sender, EventArgs e)
        {
            MathExeprission += ((Button)sender).Text;
            ApplyDot = false;
            ApplyOperation = true;
            ApplyMinus = false;
        }

        private void Operation_Click(object sender, EventArgs e)
        {
#if DEBUG
            MathExepressionRichTextBox.SelectionCharOffset = 44;
            MathExepressionRichTextBox.SelectionFont = new Font(MathExepressionRichTextBox.Font.Name, 8);
#endif
            string operation = ((Button)sender).Text;
            if (!ParseOperation(operation)) Console.Beep();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            string s = ((Button)sender).Text;
            if (!ProcessNumber(s))
            {
                Console.Beep();
                ApplyOperation = true;
            }
        }

        private void CurrentMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentMode = (CalculatorMode)CurrentModeComboBox.SelectedIndex;
            MathExeprissionLabel.Focus();
            Clear();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            ProcessKeyInput(e);
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText($"{MathExeprission} = {Result}", TextDataFormat.UnicodeText);
        }

        private void BarcketButton_Click(object sender, EventArgs e)
        {
            MathExeprission += ((Button)sender).Text;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            IsMenuOpened = !IsMenuOpened;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MenuItemsPanel.Hide();
        }

        private void AddToMemoryButton_Click(object sender, EventArgs e)
        {
            CalculateNumbers();
            if (CurrentMode == CalculatorMode.Developer)
            {
                MemoryManager.AppendLine($"{MathExeprission} = {Result}");
                return;
            }
            if (Result != null)
            {
                MemoryManager.AppendLine($"{MathExeprission} = {Result}");
                return;
            }
            if (CurrentError != null)
            {
                Error.ThrowError((ApplicationErrors)CurrentError);
            }
        }

        private void MemoryButton_Click(object sender, EventArgs e)
        {
            MemoryForm mf = new MemoryForm();
            mf.ShowDialog(this);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog(this);
        }

        private void ANSButton_Click(object sender, EventArgs e)
        {
            MathExeprission += ANS.ToString();
        }

        #endregion

        #region Methods

        private void CalculateDefault()
        {
            ResultLabel.BackColor = SystemColors.InactiveCaption;
            try
            {
                ANS = MathExeprission.ReplaceVariables(VariablesManager.ReadVariables()).GetNaitveMathExeprission().Calculate();
                Result = ANS;
            }
            catch
            {

                /*
                 * Because here there is a label for errors
                 */
                ShowError(ApplicationErrors.CalculatingError);
                //Error.ThrowError(ApplicationErrors.CalculatingError);
            }
        }

        protected void ShowError(ApplicationErrors error)
        {
            ResultLabel.Text = Texts.GetString(error.ToString());
            ResultLabel.BackColor = Color.Red;
            CurrentError = error;
        }

        protected void RemoveError()
        {
            ResultLabel.BackColor = SystemColors.InactiveCaption;
            ResultLabel.Text = "";
        }

        private void CalculateDegrees()
        {
            try
            {
                ResultLabel.Text = DegreesCalculator.ConvertDegree((DegreeType)FromComboBox.SelectedIndex, (DegreeType)ToComboBox.SelectedIndex, decimal.Parse(MathExeprissionLabel.Text)).ToString();
            }
            catch
            {
                /*
                 * Because we have a label for errors
                 */
                ShowError(ApplicationErrors.ConversionError);
            }
            
        }

        internal void ProcessKeyInput(KeyEventArgs e)
        {
            MathExeprissionLabel.Focus();
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(MathExeprission))
            {
                CalculateNumbers();
                return;
            }

            if (e.KeyCode == Keys.Delete)
            {
                Clear();
            }

            if (e.KeyCode == Keys.Back)
            {
                PerformBackspace();
            }

            string input = e.KeyCode.ToString().ToLower().Replace("numpad", "");

            input = input.Replace("add", "+");
            input = input.Replace("subtract", "-");
            input = input.Replace("multiply", "×");
            input = input.Replace("divide", "÷");

            ProcessNumber(input);
        }

        private bool ParseOperation(string oper)
        {
            if (Result == null)
            {
                ClearResult();
            }
            if (!ApplyOperation)
            {
                if (ApplyMinus && oper == "-")
                {
                    MathExeprission += oper;
                    ApplyMinus = false;
                }
                return false;
            }

            foreach (string operation in AppliedOperations)
            {
                if (oper == operation)
                {
                    goto Next;
                }
            }
#if DEBUG
            throw new ArgumentException("Not Applied operation!", nameof(oper));
#else
            Error.ShowError(this, Texts.GetString("OperationError"), Constants.ReadMeFileName);
#endif

        Next:
            if (!string.IsNullOrEmpty(ResultLabel.Text))
            {
                MathExeprission = ResultLabel.Text;
                ResultLabel.Text = "";
            }

            string operText = $" {oper} ";
            MathExeprission += operText;
            ApplyOperation = false;
            ApplyDot = true;
            ApplyMinus = true;
            return true;
        }

        private bool ProcessNumber(string number)
        {
            if (Result == null)
            {
                ClearResult();
            }
            if (!string.IsNullOrWhiteSpace(ResultLabel.Text))
            {
                Clear();
            }

            if (number == "." && ApplyDot)
            {
                ApplyDot = false;
                MathExeprission += ".";
                return true;
            }

            else if (number == "π (ط)")
            {
                MathExeprission += Math.Round(Math.PI, 5);
            }

            if (AllowHexadecimal && Regex.IsMatch(number, "[a-f]"))
            {
                MathExeprission += number.ToUpper();
            }

            if (Regex.IsMatch(number, "[+|\\-|×|÷]"))
            {
                ParseOperation(number);
                return true;
            }

            if (number.Length > 1)
            {
                return false;
            }

            if (Regex.IsMatch(number, "[0-9]"))
            {
                ApplyOperation = true;
                MathExeprission += number;
                return true;
            }

            return false;
        }

        // API
        public void CalculateNumbers()
        {
            switch (CurrentMode)
            {
                case CalculatorMode.Default:
                    CalculateDefault();
                    return;
                case CalculatorMode.Degrees:
                    CalculateDegrees();
                    return;
                case CalculatorMode.Developer:
                    CalculateDeveloper();
                    return;
            }
        }

        private void CalculateDeveloper()
        {
            int[] enumValues = (int[])typeof(NumbersMode).GetEnumValues();
            NumbersMode from = (NumbersMode)enumValues[FromComboBox.SelectedIndex];
            NumbersMode to = (NumbersMode)enumValues[ToComboBox.SelectedIndex];
            ResultLabel.Text = ConvertDeveloper(MathExeprission, from, to);
        }

        public string ConvertDeveloper(string value, NumbersMode from, NumbersMode to)
        {
            string[] data = value.Split('.');
            string beforePoint = data[0];
            string afterPoint = null;
            int zeroCount = 0;
            GC.Collect();

            try
            {
                if (data.Length > 1)
                {
                    afterPoint = data[1];
                    foreach (char c in afterPoint.ToCharArray())
                    {
                        if (c != '0')
                        {
                            break;
                        }
                        zeroCount++;
                    }
                    afterPoint.Remove(0, zeroCount);
                    afterPoint = Convert.ToString(value: Convert.ToInt64(afterPoint, (int)from), toBase: (int)to);
                }
                beforePoint = Convert.ToString(value: Convert.ToInt64(beforePoint, (int)from), toBase: (int)to);
            }
            catch
            {
                ShowError(ApplicationErrors.ConversionError);
            }
            
            if (afterPoint != null)
            {
                return $"{beforePoint}.{new string('0', zeroCount)}{afterPoint}";
            }
            return beforePoint.ToString();
        }

        // API
        public void Clear()
        {
            ApplyOperation = false;
            ApplyDot = true;
            MathExeprission = "";
            ClearResult();
        }

        // API
        public void ClearResult()
        {
            ResultLabel.Text = "";
            ResultLabel.BackColor = MainBoardColor;
        }

        #endregion

        internal void RefreshMenu()
        {
            AnimationFlags flags = AnimationFlags.Activate | AnimationFlags.Slide;
            bool isRTL = CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft;

            if (isRTL) OpenFlags = flags | AnimationFlags.Right;
            else OpenFlags = flags | AnimationFlags.Left;

            //---
            flags = AnimationFlags.Hide | AnimationFlags.Slide;

            if (isRTL) CloseFlags = flags | AnimationFlags.Left;
            else CloseFlags = flags | AnimationFlags.Right;
        }

        private void MainForm_TextChanged(object sender, EventArgs e)
        {
            string caption = Texts.GetString("Name");
            if (Text != caption)
            {
                Text = caption;
            }
        }

        private void MainForm_RightToLeftLayoutChanged(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        private void FromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentMode == CalculatorMode.Developer)
            {
                switch (FromComboBox.SelectedIndex)
                {
                    case 3: // Hex
                        AllowHexadecimal = true;
                        SetButtonsEnabled(true);
                        break;

                    case 2: // Dec
                        AllowHexadecimal = false;
                        SetButtonsEnabled(true);
                        break;

                    case 1: // Oct
                        AllowHexadecimal = false;
                        SetButtonsEnabled(true);
                        ButtonNumber8.Enabled = false;
                        ButtonNumber9.Enabled = false;
                        break;
                    case 0: // Bin
                        AllowHexadecimal = false;
                        SetButtonsEnabled(false);
                        break;
                    default:
                        break;
                }
            }
        }

        protected void SetButtonsEnabled(bool enabled)
        {
            ButtonNumber9.Enabled = enabled;
            ButtonNumber8.Enabled = enabled;
            ButtonNumber7.Enabled = enabled;
            ButtonNumber6.Enabled = enabled;
            ButtonNumber5.Enabled = enabled;
            ButtonNumber4.Enabled = enabled;
            ButtonNumber3.Enabled = enabled;
            ButtonNumber2.Enabled = enabled;
        }

        private void ButtonNumberX_EnabledChanged(object sender, EventArgs e)
        {
            Button btnNumX = (Button)sender;
            if (btnNumX.Enabled == false)
            {
                btnNumX.BackColor = SystemColors.Control;
                return;
            }

            btnNumX.BackColor = SystemColors.ControlLightLight;
        }

        private void ConversionComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveError();
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            IsInsidePower = !IsInsidePower;
        }
    }
}
