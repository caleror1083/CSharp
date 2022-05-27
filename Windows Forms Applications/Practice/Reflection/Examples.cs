using System;
using System.Reflection;
using System.Windows.Forms;

namespace Reflection
	{
		public partial class Examples : Form
			{
				public Examples()
					{
						InitializeComponent();
					}

				private void DiscoverTypeInformationButton_Click(object sender, EventArgs e)
					{
						string typeName = TypeNameTextBox.Text;
						Type myType = Type.GetType(typeName);
						ConstructorsListBox.Items.Clear();
						MethodsListBox.Items.Clear();
						PropertiesListBox.Items.Clear();

						// Constructors List Box Information
						ConstructorInfo[] myConstructors = myType.GetConstructors();

						foreach (ConstructorInfo constructor in myConstructors)
							{
								ConstructorsListBox.Items.Add($"{constructor}");
							}

						// Methods List Box Information
						MethodInfo[] myMethods = myType.GetMethods();

						foreach (MethodInfo method in myMethods)
							{
								MethodsListBox.Items.Add($"{method}");
							}

						// Properties List Box Information
						PropertyInfo[] myProperties = myType.GetProperties();

						foreach (PropertyInfo property in myProperties)
							{
								PropertiesListBox.Items.Add($"{property.PropertyType.Name} {property.Name}");
							}
					}
			}
	}