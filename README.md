The Problem
===========
We all know and love (haha) Citrix and their wonderful products like the Citrix Online Plug-in. If you still have to use this little piece of crap (like me) sooner or later you might run into the situation of changing stuff like the server url remotly - and you just can't do it, cause there are no group policy templates out there which can push all the special settings to your clients. You know why? Cause they store the configuration in a `REG_BINARY` value in `HKCU\Software\Citrix\PNAgent\Component Model 000`, isn't that great? Too much alcohol during the development progress in my opinion...

The Solution
============
My `CitrixConfigurator` extracts the crippled xml-style configuration from the registry, converts it into indented readable xml and writes it back. It can also provide you a reg-compatible hex-string you may deploy via group policy preferences, VB scripts, CMD one-liners or batch files. Any questions left? Just download and start it, it makes your life with Citrix easier ![Smily](http://nefarius.at/wp-content/plugins/wp-monalisa/icons/smiley-lol.png "Smily")

![Main Window](http://www1.xup.to/exec/ximg.php?fid=16960371 "Main Window")
