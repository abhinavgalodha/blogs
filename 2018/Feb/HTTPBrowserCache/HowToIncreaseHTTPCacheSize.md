## Why to increase HTTP Cache Size

1. Offline access.
2. Load the content in a faster way.

# How to Increase Http Cache Size in Browsers

Different browsers provide various ways to increase the HTTP Cache size. This document is a step by step guide to increase the Browser Cache in various Browsers (Chrome, Firefox, IE).

## Increase Cache Size in Chrome
Currently, the Chrome Browser doesn't provide a way to set the Max Size of HTTP Cache in the UI. However, we can add a parameter **(disk-cache-size)**, using command line. 

1. Open the Google Chrome Executable properties. Type Google Chrome in  the Search Programs in the Start menu.

![Image](Images/Chrome1.png)

2. Right click on the properties of the Google Chrome Executable and open the Shortcut tab.

![Image](Images/Chrome2.png)

3. Add the parameter --disk-cache-size=52428800
The entered size is in MB. So, 52428800 bytes is equivalent to 50 MB.

4. Press **Ok** or **Apply** and launch the Google Chrome.

## Increase Cache Size in Mozilla Firefox

1. Launch the Firefox.

2. Go to Tools -> options.

![Image](Images/Firefox1.png)

3. Select Privacy and Security options in the left side.

4. Scroll down to Cached Web Content section. You would be able to see the current cache size. For e.g. on my machine The text is Your web content cache is currently using 349 MB of disc space.

5. Check the Override automatic cache management Checkbox.

6. Enter the value in the textbox next to Limit Cache to.  The entered  value is calculated as Mb unit.

![Image](Images/Firefox2.png)

## Increase Cache size in Internet Explorer (IE)

1. Launch the internet explorer.

2. Go to Tools -> Internet options.

![Internet Options](Images/IE1.png)

3. Next, in General Tab, Under Browser History, Click Settings button.

![Settings](Images/IE2.png)

4. Above step would open up a new Dialog, On Temporary Internet files tab, select the Automatically radio button under the Check for new version Of stored pages.

![Set cache size](Images/IE3.png)

5. Next, set the desired value of the Disk Space to use in the textbox. The entered  value is calculated as Mb unit.

6. Click Ok and then again Ok/Apply and settings would be saved.

7. Close IE and open again.