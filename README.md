Pocket-.Net
===========

This is a simple .Net library for accessing Pocket (Formerly Read it Later). It is still primitive but it does the job for myself.
Please see the demo project for more info.

Get your Consumer Key and Access Token from here:
http://getpocket.com/developer/docs/authentication

Initial Pocket
Pocket pocket = new Pocket("Your Consumer Key", "Your Access Token");

Add an article
Item item = pocket.Add("http://en.wikipedia.org/wiki/Pocket_(application)");

Retrieve all items
List<Item> items = pocket.Retrieve();

Modify an item
PocketAction action = new PocketAction("archive", "229279689", null);
bool result = pocket.Modify(action);