using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _004_Collections_Queue
	{
		public partial class WebForm : Page
			{
				protected void Page_Load(object sender, EventArgs e)
					{						
						if (Session["TokenQueue"] == null)
							{
								// Perform this only if there is nothing in the session variable
								Queue<int> queueTokens = new Queue<int>();  // Creating a Queue class of integers
								Session["TokenQueue"] = queueTokens;  // Storing the queue in a session variable because web apps work on a stateless protocol. To remember the state of the queue you need to store it in a session variable
							}
					}

				protected void PrintTokenButton_Click(object sender, EventArgs e)
					{
						// Retrieve the tokenQueue from the Session variable
						Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];  // whatever is being retrieved from the session variable needs to be typecasted
						StatusLabel.Text = $"There are {tokenQueue.Count} customers before you in the queue";

						// Compute the next token number to be issued
						// if there are no items in the queue then we need to start at token 1
						if (Session["LastTokenNumberIssued"] == null)
							{
								Session["LastTokenNumberIssued"] = 0;
							}
						int nextTokenNumberToBeIssued = (int)Session["LastTokenNumberIssued"] + 1;
						Session["LastTokenNumberIssued"] = nextTokenNumberToBeIssued;
						tokenQueue.Enqueue(nextTokenNumberToBeIssued);

						AddTokensToListbox(tokenQueue);  // Add tokens to listbox
					}

				private void AddTokensToListbox(Queue<int> tokenQueue)
					{
						TokensList.Items.Clear();

						foreach (int token in tokenQueue)
							{
								TokensList.Items.Add(token.ToString());
							}
					}
			}
	}