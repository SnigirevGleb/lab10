using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_TextEditor
{
    public partial class MainForm : Form
    {
        private short fontSize = 12;
        private int[] customColors;
        bool textStyle = false;

        public MainForm()
        {
            InitializeComponent();
            ToolStrip.ImageList = imageList;
            centerTSButton.ImageIndex = 0;
            rightTSButton.ImageIndex = 1;
            leftTSButton.ImageIndex = 2;
            if (MessageBox.Show("Включить текстовое отображение кнопок смены цвета и заливки текста?",
                "Текстовый редактор", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textColorTSButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
                fillingColorTSButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
                textStyle = true;
                fillingColorTSButton.BackColor = Color.White;
            }
            else
            {
                textColorTSButton.ImageIndex = 3;
                fillingColorTSButton.ImageIndex = 4;
            }
        }

        private bool TextAndFileAreEqual(RichTextBox TextEditor, string FileName)
        {
            using (RichTextBox tempBox = new RichTextBox())
            {
                try
                {
                    tempBox.LoadFile(FileName, RichTextBoxStreamType.RichText);
                }
                catch
                {
                    MessageBox.Show("Ошибка чтения файла!", "Текстовый редактор",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                string[] textLines = TextEditor.Lines;
                string[] fileLines = tempBox.Lines;
                if (textLines.Length != fileLines.Length) return false;
                for (int i = 0; i < textLines.Length; i++) if (textLines[i] != fileLines[i]) return false;
                return true;
            }
        }

        private void СоздатьToolStripButton_Click(object sender, EventArgs e)
        {
            if (Text == "Текстовый редактор")
            {
                if (TextEditor.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вы хотите сохранить изменения в этот файл?",
                               "Текстовый редактор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            saveFileDialog.Filter = "RTF files|*.rtf";
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                TextEditor.SaveFile(saveFileDialog.FileName);
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }
            }
            else
            {
                if (!TextAndFileAreEqual(TextEditor, Text.Substring(21)))
                {
                    DialogResult result = MessageBox.Show("Вы хотите сохранить изменения в этот файл?",
                           "Текстовый редактор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            TextEditor.SaveFile(Text.Substring(21));
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }
            }
            saveFileDialog.Filter = "RTF files|*.rtf";
            saveFileDialog.Title = "Создание";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextEditor.Text = "";
                TextEditor.SaveFile(saveFileDialog.FileName);
                Text = "Текстовый редактор — " + saveFileDialog.FileName;
            }
        }

        private void ОткрытьToolStripButton_Click(object sender, EventArgs e)
        {
            if (Text == "Текстовый редактор")
            {
                if (TextEditor.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вы хотите сохранить изменения в этот файл?",
                               "Текстовый редактор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            saveFileDialog.Filter = "RTF files|*.rtf";
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                TextEditor.SaveFile(saveFileDialog.FileName);
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }
            }
            else
            {
                if (!TextAndFileAreEqual(TextEditor, Text.Substring(21)))
                {
                    DialogResult result = MessageBox.Show("Вы хотите сохранить изменения в этот файл?",
                           "Текстовый редактор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            TextEditor.SaveFile(Text.Substring(21));
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }
            }
            openFileDialog.Filter = "RTF files|*.rtf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextEditor.LoadFile(openFileDialog.FileName);
                Text = "Текстовый редактор — " + openFileDialog.FileName;
            }
        }

        private void СохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            if (Text == "Текстовый редактор")
            {
                saveFileDialog.Filter = "RTF files|*.rtf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextEditor.SaveFile(saveFileDialog.FileName);
                    Text = "Текстовый редактор — " + saveFileDialog.FileName;
                }
            }
            else
            {
                if (!TextAndFileAreEqual(TextEditor, Text.Substring(21)))
                {
                    DialogResult result = MessageBox.Show("Вы хотите сохранить изменения в этот файл?",
                           "Текстовый редактор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            TextEditor.SaveFile(Text.Substring(21));
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }
            }
        }

        private void ВырезатьToolStripButton_Click(object sender, EventArgs e)
        {
            if (TextEditor.SelectionLength != 0)
            {
                Clipboard.SetText(TextEditor.SelectedText);
                TextEditor.SelectedText = "";
            }
        }

        private void КопироватьToolStripButton_Click(object sender, EventArgs e)
        {
            if (TextEditor.SelectionLength != 0) Clipboard.SetText(TextEditor.SelectedText);
        }

        private void ВставкаToolStripButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject() != null)
            {
                if (TextEditor.SelectedText != null)
                    TextEditor.SelectedText = Clipboard.GetText();
                else TextEditor.Paste();
            }
        }

        private void BoldTSButton_Click(object sender, EventArgs e)
        {
            if (BoldTSButton.Checked)
            {
                TextEditor.SelectionFont = new Font(TextEditor.SelectionFont,
                TextEditor.SelectionFont.Style | FontStyle.Bold);
                TextEditor_SelectionChanged(sender, e);
            }
            else
            {
                TextEditor.SelectionFont = new Font(TextEditor.SelectionFont,
                TextEditor.SelectionFont.Style & ~FontStyle.Bold);
                жирныйToolStripMenuItem.Checked = true;
                TextEditor_SelectionChanged(sender, e);
            }
        }

        private void ItalicTSButton_Click(object sender, EventArgs e)
        {
            if (ItalicTSButton.Checked)
            {
                TextEditor.SelectionFont = new Font(TextEditor.SelectionFont,
                TextEditor.SelectionFont.Style | FontStyle.Italic);
                TextEditor_SelectionChanged(sender, e);
            }
            else
            {
                TextEditor.SelectionFont = new Font(TextEditor.SelectionFont,
                TextEditor.SelectionFont.Style & ~FontStyle.Italic);
                TextEditor_SelectionChanged(sender, e);
            }
        }

        private void UnderlineTSButton_Click(object sender, EventArgs e)
        {
            if (UnderlineTSButton.Checked)
            {
                TextEditor.SelectionFont = new Font(TextEditor.SelectionFont,
                TextEditor.SelectionFont.Style | FontStyle.Underline);
                TextEditor_SelectionChanged(sender, e);
            }
            else
            {
                TextEditor.SelectionFont = new Font(TextEditor.SelectionFont,
                TextEditor.SelectionFont.Style & ~FontStyle.Underline);
                TextEditor_SelectionChanged(sender, e);
            }
        }

        private void SizeTSComboBox_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                fontSize = Convert.ToInt16(SizeTSComboBox.SelectedItem.ToString());
            }
            catch { }
            TextEditor.SelectionFont = new Font(TextEditor.SelectionFont.FontFamily,
                fontSize);
            SizeTSComboBox.Text = fontSize.ToString();
            SizeTSCBMM.Text = fontSize.ToString();
            TextEditor.Focus();
            TextEditor_SelectionChanged(sender, e);
        }

        private void SizeTSComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    short newSize = Convert.ToInt16(SizeTSComboBox.Text);
                    if (newSize > 500) newSize = 500;
                    if (newSize < 5) newSize = 5;
                    fontSize = newSize;
                }
                catch { }
                SizeTSComboBox.Text = fontSize.ToString();
                SizeTSCBMM.Text = fontSize.ToString();
                TextEditor.SelectionFont = new Font(TextEditor.SelectionFont.FontFamily,
                fontSize);
                e.SuppressKeyPress = true;
                TextEditor.Focus();
                TextEditor_SelectionChanged(sender, e);
            }
        }

        private void SizeTSComboBox_Validated(object sender, EventArgs e)
        {
            SizeTSComboBox.Text = fontSize.ToString();
            SizeTSCBMM.Text = fontSize.ToString();
            TextEditor.Focus();
            TextEditor_SelectionChanged(sender, e);
        }

        private void TextColorTSButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (customColors != null)
                colorDialog.CustomColors = customColors;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                customColors = colorDialog.CustomColors;
                TextEditor.SelectionColor = colorDialog.Color;
                textColorTSButton.ForeColor = colorDialog.Color;
                цветШрифтаToolStripMenuItem.ForeColor = colorDialog.Color;
            }
        }

        private void FillingColorTSButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (customColors != null)
                colorDialog.CustomColors = customColors;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                customColors = colorDialog.CustomColors;
                TextEditor.SelectionBackColor = colorDialog.Color;
                if (textStyle) fillingColorTSButton.BackColor = colorDialog.Color;
                цветЗаливкиToolStripMenuItem.ForeColor = colorDialog.Color;
            }
        }

        private void FontTSButton_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog
            {
                FontMustExist = true,
                MaxSize = 500,
                MinSize = 5,
                AllowVerticalFonts = false
            };
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                TextEditor.SelectionFont = fontDialog.Font;
                fontTSButton.Text = fontDialog.Font.Name;
                fontTSMM.Text = fontDialog.Font.Name;
                SizeTSComboBox.Text = fontDialog.Font.Size.ToString();
                SizeTSCBMM.Text = fontDialog.Font.Size.ToString();
            }
            TextEditor_SelectionChanged(sender, e);
        }

        private void CenterTSButton_Click(object sender, EventArgs e)
        {
            if (TextEditor.SelectionAlignment == HorizontalAlignment.Center)
            {
                TextEditor.SelectionAlignment = HorizontalAlignment.Left;
                centerTSButton.Checked = false;
                leftTSButton.Checked = true;
                выровнятьПоЦентруToolStripMenuItem.Checked = false;
                выровнятьПоЛевомуКраюToolStripMenuItem.Checked = true;
            }
            else
            {
                TextEditor.SelectionAlignment = HorizontalAlignment.Center;
                centerTSButton.Checked = true;
                rightTSButton.Checked = false;
                leftTSButton.Checked = false;
                выровнятьПоЦентруToolStripMenuItem.Checked = true;
                выровнятьПоПравомуКраюToolStripMenuItem.Checked = false;
                выровнятьПоЛевомуКраюToolStripMenuItem.Checked = false;
            }
        }

        private void RightTSButton_Click(object sender, EventArgs e)
        {
            if (TextEditor.SelectionAlignment == HorizontalAlignment.Right)
            {
                TextEditor.SelectionAlignment = HorizontalAlignment.Left;
                rightTSButton.Checked = false;
                leftTSButton.Checked = true;
                выровнятьПоПравомуКраюToolStripMenuItem.Checked = false;
                выровнятьПоЛевомуКраюToolStripMenuItem.Checked = true;
            }
            else
            {
                TextEditor.SelectionAlignment = HorizontalAlignment.Right;
                centerTSButton.Checked = false;
                rightTSButton.Checked = true;
                leftTSButton.Checked = false;
                выровнятьПоЦентруToolStripMenuItem.Checked = false;
                выровнятьПоПравомуКраюToolStripMenuItem.Checked = true;
                выровнятьПоЛевомуКраюToolStripMenuItem.Checked = false;
            }
        }

        private void LeftTSButton_Click(object sender, EventArgs e)
        {
            TextEditor.SelectionAlignment = HorizontalAlignment.Left;
            centerTSButton.Checked = false;
            rightTSButton.Checked = false;
            leftTSButton.Checked = true;
            выровнятьПоЦентруToolStripMenuItem.Checked = false;
            выровнятьПоПравомуКраюToolStripMenuItem.Checked = false;
            выровнятьПоЛевомуКраюToolStripMenuItem.Checked = true;
        }

        private void СправкаToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель программы: студент ВятГУ группы ФИб-2301 Снигирев Глеб Николаевич",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void СоздатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Text == "Текстовый редактор")
            {
                if (TextEditor.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вы хотите сохранить изменения в этот файл?",
                               "Текстовый редактор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            saveFileDialog.Filter = "RTF files|*.rtf";
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                TextEditor.SaveFile(saveFileDialog.FileName);
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }
            }
            else
            {
                if (!TextAndFileAreEqual(TextEditor, Text.Substring(21)))
                {
                    DialogResult result = MessageBox.Show("Вы хотите сохранить изменения в этот файл?",
                           "Текстовый редактор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            TextEditor.SaveFile(Text.Substring(21));
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }
            }
            saveFileDialog.Filter = "RTF files|*.rtf";
            saveFileDialog.Title = "Создание";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextEditor.Text = "";
                TextEditor.SaveFile(saveFileDialog.FileName);
                Text = "Текстовый редактор — " + saveFileDialog.FileName;
            }
        }

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Text == "Текстовый редактор")
            {
                if (TextEditor.Text != "")
                {
                    DialogResult result = MessageBox.Show("Вы хотите сохранить изменения в этот файл?",
                               "Текстовый редактор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            saveFileDialog.Filter = "RTF files|*.rtf";
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                TextEditor.SaveFile(saveFileDialog.FileName);
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }
            }
            else
            {
                if (!TextAndFileAreEqual(TextEditor, Text.Substring(21)))
                {
                    DialogResult result = MessageBox.Show("Вы хотите сохранить изменения в этот файл?",
                           "Текстовый редактор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            TextEditor.SaveFile(Text.Substring(21));
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }
            }
            openFileDialog.Filter = "RTF files|*.rtf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextEditor.LoadFile(openFileDialog.FileName);
                Text = "Текстовый редактор — " + openFileDialog.FileName;
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Text == "Текстовый редактор")
            {
                saveFileDialog.Filter = "RTF files|*.rtf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextEditor.SaveFile(saveFileDialog.FileName);
                    Text = "Текстовый редактор — " + saveFileDialog.FileName;
                }
            }
            else
            {
                if (!TextAndFileAreEqual(TextEditor, Text.Substring(21)))
                {
                    DialogResult result = MessageBox.Show("Вы хотите сохранить изменения в этот файл?",
                           "Текстовый редактор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            TextEditor.SaveFile(Text.Substring(21));
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }
            }
        }

        private void ВырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextEditor.SelectionLength != 0)
            {
                Clipboard.SetText(TextEditor.SelectedText);
                TextEditor.SelectedText = "";
            }
        }

        private void КопироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextEditor.SelectionLength != 0) Clipboard.SetText(TextEditor.SelectedText);
        }

        private void ВставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject() != null)
            {
                if (TextEditor.SelectedText != null)
                    TextEditor.SelectedText = Clipboard.GetText();
                else TextEditor.Paste();
            }
        }

        private void ТекстToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                short newSize = Convert.ToInt16(SizeTSCBMM.Text);
                if (newSize > 500) newSize = 500;
                if (newSize < 5) newSize = 5;
                fontSize = newSize;
            }
            catch { }
            SizeTSComboBox.Text = fontSize.ToString();
            SizeTSCBMM.Text = fontSize.ToString();
            TextEditor.SelectionFont = new Font(TextEditor.SelectionFont.FontFamily,
            fontSize);
            TextEditor.Focus();
            TextEditor_SelectionChanged(sender, e);
        }

        private void ЖирныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (жирныйToolStripMenuItem.Checked)
            {
                TextEditor.SelectionFont = new Font(TextEditor.SelectionFont,
                TextEditor.SelectionFont.Style | FontStyle.Bold);
                TextEditor_SelectionChanged(sender, e);
            }
            else
            {
                TextEditor.SelectionFont = new Font(TextEditor.SelectionFont,
                TextEditor.SelectionFont.Style & ~FontStyle.Bold);
                TextEditor_SelectionChanged(sender, e);
            }
        }

        private void КурсивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (курсивToolStripMenuItem.Checked)
            {
                TextEditor.SelectionFont = new Font(TextEditor.SelectionFont,
                TextEditor.SelectionFont.Style | FontStyle.Italic);
                TextEditor_SelectionChanged(sender, e);
            }
            else
            {
                TextEditor.SelectionFont = new Font(TextEditor.SelectionFont,
                TextEditor.SelectionFont.Style & ~FontStyle.Italic);
                TextEditor_SelectionChanged(sender, e);
            }
        }

        private void ПодчёркнутыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (подчёркнутыйToolStripMenuItem.Checked)
            {
                TextEditor.SelectionFont = new Font(TextEditor.SelectionFont,
                TextEditor.SelectionFont.Style | FontStyle.Underline);
                TextEditor_SelectionChanged(sender, e);
            }
            else
            {
                TextEditor.SelectionFont = new Font(TextEditor.SelectionFont,
                TextEditor.SelectionFont.Style & ~FontStyle.Underline);
                TextEditor_SelectionChanged(sender, e);
            }
        }

        private void SizeTSCBMM_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                fontSize = Convert.ToInt16(SizeTSCBMM.SelectedItem.ToString());
            }
            catch { }
            TextEditor.SelectionFont = new Font(TextEditor.SelectionFont.FontFamily,
                fontSize);
            SizeTSComboBox.Text = fontSize.ToString();
            SizeTSCBMM.Text = fontSize.ToString();
            TextEditor.Focus();
            TextEditor_SelectionChanged(sender, e);
        }

        private void SizeTSCBMM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    short newSize = Convert.ToInt16(SizeTSCBMM.Text);
                    if (newSize > 500) newSize = 500;
                    if (newSize < 5) newSize = 5;
                    fontSize = newSize;
                }
                catch { }
                SizeTSComboBox.Text = fontSize.ToString();
                SizeTSCBMM.Text = fontSize.ToString();
                TextEditor.SelectionFont = new Font(TextEditor.SelectionFont.FontFamily,
                fontSize);
                e.SuppressKeyPress = true;
                TextEditor.Focus();
                TextEditor_SelectionChanged(sender, e);
            }
        }

        private void SizeTSCBMM_Validated(object sender, EventArgs e)
        {
            try
            {
                short newSize = Convert.ToInt16(SizeTSCBMM.Text);
                if (newSize > 500) newSize = 500;
                if (newSize < 5) newSize = 5;
                fontSize = newSize;
            }
            catch { }
            SizeTSComboBox.Text = fontSize.ToString();
            SizeTSCBMM.Text = fontSize.ToString();
            TextEditor.SelectionFont = new Font(TextEditor.SelectionFont.FontFamily,
            fontSize);
            TextEditor.Focus();
            TextEditor_SelectionChanged(sender, e);
        }

        private void ЦветШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (customColors != null)
                colorDialog.CustomColors = customColors;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                customColors = colorDialog.CustomColors;
                TextEditor.SelectionColor = colorDialog.Color;
                textColorTSButton.ForeColor = colorDialog.Color;
                цветШрифтаToolStripMenuItem.ForeColor = colorDialog.Color;
            }
        }

        private void ЦветЗаливкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (customColors != null)
                colorDialog.CustomColors = customColors;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                customColors = colorDialog.CustomColors;
                TextEditor.SelectionBackColor = colorDialog.Color;
                if (textStyle) fillingColorTSButton.BackColor = colorDialog.Color;
                цветЗаливкиToolStripMenuItem.ForeColor = colorDialog.Color;
            }
        }

        private void FontTSMM_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog
            {
                FontMustExist = true,
                MaxSize = 500,
                MinSize = 5,
                AllowVerticalFonts = false
            };
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                TextEditor.SelectionFont = fontDialog.Font;
                fontTSButton.Text = fontDialog.Font.Name;
                fontTSMM.Text = fontDialog.Font.Name;
                SizeTSComboBox.Text = fontDialog.Font.Size.ToString();
                SizeTSCBMM.Text = fontDialog.Font.Size.ToString();
            }
            TextEditor_SelectionChanged(sender, e);
        }

        private void ВыровнятьПоЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextEditor.SelectionAlignment == HorizontalAlignment.Center)
            {
                TextEditor.SelectionAlignment = HorizontalAlignment.Left;
                centerTSButton.Checked = false;
                leftTSButton.Checked = true;
                выровнятьПоЦентруToolStripMenuItem.Checked = false;
                выровнятьПоЛевомуКраюToolStripMenuItem.Checked = true;
            }
            else
            {
                TextEditor.SelectionAlignment = HorizontalAlignment.Center;
                centerTSButton.Checked = true;
                rightTSButton.Checked = false;
                leftTSButton.Checked = false;
                выровнятьПоЦентруToolStripMenuItem.Checked = true;
                выровнятьПоПравомуКраюToolStripMenuItem.Checked = false;
                выровнятьПоЛевомуКраюToolStripMenuItem.Checked = false;
            }
        }

        private void ВыровнятьПоПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextEditor.SelectionAlignment == HorizontalAlignment.Right)
            {
                TextEditor.SelectionAlignment = HorizontalAlignment.Left;
                rightTSButton.Checked = false;
                leftTSButton.Checked = true;
                выровнятьПоПравомуКраюToolStripMenuItem.Checked = false;
                выровнятьПоЛевомуКраюToolStripMenuItem.Checked = true;
            }
            else
            {
                TextEditor.SelectionAlignment = HorizontalAlignment.Right;
                centerTSButton.Checked = false;
                rightTSButton.Checked = true;
                leftTSButton.Checked = false;
                выровнятьПоЦентруToolStripMenuItem.Checked = false;
                выровнятьПоПравомуКраюToolStripMenuItem.Checked = true;
                выровнятьПоЛевомуКраюToolStripMenuItem.Checked = false;
            }
        }

        private void ВыровнятьПоЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditor.SelectionAlignment = HorizontalAlignment.Left;
            centerTSButton.Checked = false;
            rightTSButton.Checked = false;
            leftTSButton.Checked = true;
            выровнятьПоЦентруToolStripMenuItem.Checked = false;
            выровнятьПоПравомуКраюToolStripMenuItem.Checked = false;
            выровнятьПоЛевомуКраюToolStripMenuItem.Checked = true;
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель программы: студент ВятГУ группы ФИб-2301 Снигирев Глеб Николаевич",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void TextEditor_SelectionChanged(object sender, EventArgs e)
        {
            if (TextEditor.SelectionFont == null) return;
            BoldTSButton.Checked = TextEditor.SelectionFont.Bold;
            ItalicTSButton.Checked = TextEditor.SelectionFont.Italic;
            UnderlineTSButton.Checked = TextEditor.SelectionFont.Underline;
            жирныйToolStripMenuItem.Checked = TextEditor.SelectionFont.Bold;
            курсивToolStripMenuItem.Checked = TextEditor.SelectionFont.Italic;
            подчёркнутыйToolStripMenuItem.Checked = TextEditor.SelectionFont.Underline;
            SizeTSComboBox.Text = TextEditor.SelectionFont.Size.ToString();
            SizeTSCBMM.Text = TextEditor.SelectionFont.Size.ToString();
            textColorTSButton.ForeColor = TextEditor.SelectionColor;
            цветШрифтаToolStripMenuItem.ForeColor = TextEditor.SelectionColor;
            if (textStyle)
            {
                fillingColorTSButton.BackColor = TextEditor.SelectionBackColor;
                цветЗаливкиToolStripMenuItem.ForeColor = TextEditor.SelectionBackColor;
            }
            fontTSButton.Text = TextEditor.SelectionFont.OriginalFontName;
            fontTSMM.Text = TextEditor.SelectionFont.OriginalFontName;
            switch (TextEditor.SelectionAlignment)
            {
                case HorizontalAlignment.Center:
                    centerTSButton.Checked = true;
                    rightTSButton.Checked = false;
                    leftTSButton.Checked = false;
                    выровнятьПоЦентруToolStripMenuItem.Checked = true;
                    выровнятьПоПравомуКраюToolStripMenuItem.Checked = false;
                    выровнятьПоЛевомуКраюToolStripMenuItem.Checked = false;
                    break;
                case HorizontalAlignment.Right:
                    centerTSButton.Checked = false;
                    rightTSButton.Checked = true;
                    leftTSButton.Checked = false;
                    выровнятьПоЦентруToolStripMenuItem.Checked = false;
                    выровнятьПоПравомуКраюToolStripMenuItem.Checked = true;
                    выровнятьПоЛевомуКраюToolStripMenuItem.Checked = false;
                    break;
                case HorizontalAlignment.Left:
                    centerTSButton.Checked = false;
                    rightTSButton.Checked = false;
                    leftTSButton.Checked = true;
                    выровнятьПоЦентруToolStripMenuItem.Checked = false;
                    выровнятьПоПравомуКраюToolStripMenuItem.Checked = false;
                    выровнятьПоЛевомуКраюToolStripMenuItem.Checked = true;
                    break;
            }
        }
    }
}