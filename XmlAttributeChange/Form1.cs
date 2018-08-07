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
using System.Xml;

namespace XmlAttributeChange
{
    public partial class Form1 : Form
    {

        private string path;
        private string rootName;
        private string strAttribute;
        private List<string> attributes=new List<string>();

        private int opera;

        private float parm;
        public Form1()
        {
            InitializeComponent();
            rbjia.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbXmlPath.Text))
            {
                MessageBox.Show("文件路径不能为空", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(tbXmlPath.Text))
            {
                MessageBox.Show("文件不存在", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbRootName.Text))
            {
                MessageBox.Show("根节点名不能为空", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbXmlAttribute.Text))
            {
                MessageBox.Show("修改的属性值不能为空", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbparams.Text))
            {
                MessageBox.Show("修改的参数值不能为空", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            path = tbXmlPath.Text;
            rootName = tbRootName.Text;
            strAttribute = tbXmlAttribute.Text;
            string[] attrs = strAttribute.Split(';');
            attributes.Clear();
            if (attrs.Length>0)
            {
                for (int i = 0; i < attrs.Length; i++)
                {
                    if (!string.IsNullOrEmpty(attrs[i]))
                    {
                        attributes.Add(attrs[i]);
                    }
                }
            }
            if (attributes.Count<1)
            {
                MessageBox.Show("需要修改的属性值为空", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbjia.Checked)
            {
                opera = 1;
            }
            else if (rbjian.Checked)
            {
                opera = 2;
            }
            else if(rbcheng.Checked)
            {
                opera = 3;
            }
            else if (rbchu.Checked)
            {
                opera = 4;
            }
            else if (rbyu.Checked)
            {
                opera = 5;
            }
            if (!float.TryParse(tbparams.Text ,out parm))
            {
                MessageBox.Show("输入的参数有误", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Change(path);
        }


        private void Change(string path)
        {
            /*StreamReader sr=new StreamReader(path);
            string contets= sr.ReadToEnd();

            byte []bytes = Encoding.Default.GetBytes(contets);

            MemoryStream ms = new MemoryStream(bytes);
            XmlReaderSettings sets = new XmlReaderSettings();
            sets.IgnoreComments = true;
            sets.IgnoreProcessingInstructions = true;
            sets.IgnoreWhitespace = true;
            sets.ValidationType = ValidationType.None;
            sets.ValidationFlags = System.Xml.Schema.XmlSchemaValidationFlags.None;
            sets.ProhibitDtd = true;
            sets.ConformanceLevel = ConformanceLevel.Document;
            XmlReader xmr = XmlReader.Create(ms, sets);
            string curName = "";
            try
            {
                while (xmr.Read())
                {
                    if (xmr.NodeType == XmlNodeType.Element)
                    {
                        SimpleVariant node = new SimpleVariant();

                        if (stack.Count > 0)
                        {
//has parent
                            SimpleVariant parent = stack.Peek();
                            if (!parent.ContainsKey(xmr.Name))
                            {
                                //parent[xmr.Name] = new Variant();
                                //parent.AddData(xmr.Name,new SimpleVariant());
                            }

                            //parent[xmr.Name].pushBack(node);
                            parent.AddData(xmr.Name, node);
                            curNode = parent;
                            curName = xmr.Name;
                        }
                        else
                            rootNode = node;

                        if (!xmr.IsEmptyElement)
                        {
                            stack.Push(node);
                        }

                        while (xmr.MoveToNextAttribute())
                        {
                            //node[xmr.Name] = new Variant(xmr.Value);
                            node.AddAttri(xmr.Name, xmr.Value);
                        }
                    }
                    else if (xmr.NodeType == XmlNodeType.Text)
                    {
                        if (curNode != null && !string.IsNullOrEmpty(curName))
                        {
                            curNode.SetData(curName, xmr.Value);
                        }
                    }
                    else if (xmr.NodeType == XmlNodeType.EndElement)
                    {
                        stack.Pop();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            xmr.Close();
            ms.Close();
            */
            XmlDocument doc=new XmlDocument();
            try
            {
                doc.Load(path);
                XmlNode rootNode= doc.SelectSingleNode(rootName);
                ChangeAttributes(rootNode);
                doc.Save(path);
                MessageBox.Show("操作完成", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ChangeAttributes(XmlNode node)
        {
            XmlElement element = node as XmlElement;
            if (element != null)
            {
                if (element.HasAttributes)
                {
                    for (int i = 0; i < element.Attributes.Count; i++)
                    {
                        if (attributes.Contains(element.Attributes[i].Name))
                        {
                            element.Attributes[i].Value = ChangeValue(element.Attributes[i].Value);
                        }
                    }
                }
                if (element.ChildNodes.Count>0)
                {
                    for (int i = 0; i < element.ChildNodes.Count; i++)
                    {
                        ChangeAttributes(element.ChildNodes.Item(i));
                    }
                }
            }
        }

        private string ChangeValue(string value)
        {
            string result = value;
            double floattem = 0;
            double temp = 0;
            if (double.TryParse(value,out floattem))
            {
                switch (opera)
                {
                    case 1:
                        temp = floattem + parm;
                        break;
                    case 2:
                        temp = floattem - parm;
                        break;
                    case 3:
                        temp = floattem * parm;
                        break;
                    case 4:
                        temp = floattem / parm;
                        break;
                    case 5:
                        temp = floattem % parm;
                        break;
                }
            }
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    result = temp.ToString();
                    break;
                case 1:
                    result = Math.Floor(temp).ToString();
                    break;
                case 2:
                    result = ((long)temp).ToString();
                    break;
                case 3:
                    result = Convert.ToInt64(temp).ToString();
                    break;
            }

            return result;
        }
    }
}
