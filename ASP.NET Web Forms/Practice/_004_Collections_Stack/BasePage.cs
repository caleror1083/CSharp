using System;
using System.Collections.Generic;
using System.Web.UI;

namespace _004_Collections_Stack
	{
		public class BasePage : Page
			{
				protected override void OnLoad(EventArgs e)  // raises the Load event - overriding the OnLoad method in System.Web.UI.Control
					{
						if (Session["URLStack"] == null)
							{
								Stack<string> urlStack = new Stack<string>();
								Session["URLStack"] = urlStack;
							}

						if (Request.UrlReferrer != null && !Page.IsPostBack && Session["BackButtonClicked"] == null)
							{
								Stack<string> urlStack = (Stack<string>)Session["URLStack"];
								urlStack.Push(Request.UrlReferrer.AbsoluteUri);
							}

						if (Session["BackButtonClicked"] != null)
							{
								Session["BackButtonClicked"] = null;
							}
					}
			}
	}