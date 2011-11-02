Client Resource Admin
=====================

This is a logging provider for the Client Dependency Framework to log debug, info, warning, and error messages to the DotNetNuke event viewer. At time of writing the CDF project logs the following events (and with this module these events are now noted in the DNN Event log):

* "Could not load file contents" (BaseCompositeFileProcessingProvider and CompositeFileProcessingProvider)
* "Could not load file contents. Domain is not white-listed" (BaseCompositeFileProcessingProvider)
* "Could not write file contents to stream" (CompositeFileProcessingProvider)
* "No bytes were returned" when looking for the file map (CompositeDependencyHandler)
* "No bytes were returned 5 attempts" Fatal (CompositeDependencyHandler)
* ClientDependency handler path is null (CompositeDependencyHandler)

As you can see, it's mostly useful for finding out if there is trouble getting individual files into a composite file.

Installation
------------
Download the latest installable module package from the "ModulePackages" folder. Both Install and Source are installable through the DNN UI, Source just includes the C# code.

Usage
-----
Caution: clicking save in the module will update your web.config and restart your website. Please plan accordingly.

Blog posts
----------
* [Enhancements for working with JavaScript and CSS Files in DNN 6.1][crm]
* [DNN 6.1 JS/CSS File Combination Potential Gotchas][crmpg]

Documentation
-------------
* [DNN Client Resource Management API][dnncrmwiki]
* [Client Dependency Framework][cdfwiki]

[crm]: http://www.dotnetnuke.com/Resources/Blogs/EntryId/3191/Enhancements-for-working-with-JavaScript-and-CSS-files-in-DNN-6-1.aspx
[crmpg]: http://www.dotnetnuke.com/Resources/Blogs/EntryId/3207/DNN-6-1-JS-CSS-File-Combination-Potential-Gotchas.aspx
[dnncrmwiki]: http://www.dotnetnuke.com/Resources/Wiki/Page/Client-Resource-Management-API.aspx
[cdfwiki]: http://clientdependency.codeplex.com/documentation