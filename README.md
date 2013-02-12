Pocket-.Net
===========

This is a simple .Net library for accessing Pocket (Formerly Read it Later). It is still primitive and by no means completed but it does the job for myself.

Please see the demo project for more info.

Get your Consumer Key and Access Token from here:
http://getpocket.com/developer/docs/authentication

Initialize Pocket <br />
<code>Pocket pocket = new Pocket("Your Consumer Key", "Your Access Token");</code>

Add an article<br />
<code>Item item = pocket.Add("http://en.wikipedia.org/wiki/Pocket_(application)");</code>

Retrieve all items<br />
<code>List<Item> items = pocket.Retrieve();</code>

Modify an item<br />
<code>
PocketAction action = new PocketAction("archive", "229279689", null);
bool result = pocket.Modify(action);</code>