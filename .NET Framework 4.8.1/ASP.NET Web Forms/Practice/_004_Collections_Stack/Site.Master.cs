using System;
using System.Collections.Generic;
using System.Web.UI;

namespace _004_Collections_Stack
	{
		public partial class Site : MasterPage
			{
				protected void BackButton_Click(object sender, EventArgs e)
					{
						Session["BackButtonClicked"] = "YES";

						if (Session["URLStack"] != null)
							{
								Stack<string> urlStack = (Stack<string>)Session["URLStack"];

								if (urlStack.Count > 0)
									{
										string url = urlStack.Pop();
										Response.Redirect(url);
									}
								else
									{
										MessageLabel.Text = "There are no pages in the history";
									}
							}
					}
			}
	}