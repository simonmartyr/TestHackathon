using System;
using System.Collections.Generic; 
using Foundation;
using UIKit;
using TestHackathon.BL;
namespace TestHackathon
{
	public class PostCodeTable: UITableViewSource
	{
		List<Zip> zips = BL.Mangers.ZipManager.GetZipItems(); 
		public PostCodeTable()
		{
		}


		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(zips[indexPath.Row].ID.ToString());
			string item = zips[indexPath.Row].PostCode;
			if (cell == null)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Default, "hi");
			}

			cell.TextLabel.Text = item;

			return cell; 
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return zips.Count; 
		}

	}
}
