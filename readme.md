### Environment Assessment Toolkit

### VeeamHub

Veeamhub projects are community driven projects, and are not created by Veeam R&D nor validated by Veeam Q&A. They are maintained by community members which might be or not be Veeam employees.

### Distributed under MIT license

Copyright 2017, Johan Huttenga.

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:  

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.  

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

---

PowerCLI is Copyright 2017, VMware Inc. https://www.vmware.com/support/developer/PowerCLI/
LZMA SDK is Copyright 2017 Igor Pavlov: http://www.7-zip.org/sdk.html
NTAR is Copyright 2017, Alexandre Mutel: https://github.com/xoofx/NTar
NSSPI is Copyright (c) 2014, Kevin Thompson: https://github.com/antiduh/nsspi
Bootstrap is Copyright 2017, Twitter: https://v4-alpha.getbootstrap.com/about/license/
Montserrat is Copyright 2017, Julieta Ulanovsky: https://fonts.google.com/specimen/Montserrat
Open Sans is Copyright 2017, Steve Matteson: https://fonts.google.com/specimen/Open+Sans?selection.family=Open+Sans
tealeg/XLSX is Copyright 2017, Geoffrey J. Teale: https://github.com/tealeg/xlsx/blob/master/LICENSE
guregu/null.v3 is Copyright 2014, Greg Roseberry: https://github.com/guregu/null/blob/v3.2.0/LICENSE
mattn/go-sqlite3 is Copyright 2014, Yasuhiro Matsumoto: https://github.com/mattn/go-sqlite3/blob/master/LICENSE
gorilla/handlers is Copyright 2013, The Gorilla Handlers Authors: https://github.com/gorilla/handlers/blob/master/LICENSE

---

### Project Notes

**Author:** Johan Huttenga (@johanhuttenga)

**Requirements:**
- .NET Framework 4.5
- VMware vSphere 4.x or higher.
- Hyper-V 2012 or higher.
- A user account with permissions to get Hyper-V and vSphere data.

**Usage:**
To compile from source you must download this project and have Visual Studio with .NET 4.5 support installed (https://www.visualstudio.com/vs/community/). Use EnvironmentAssessment.exe and follow the instructions in the wizard to collect data from your environment.

Dependencies are automatically embedded in resources.lzma and extracted upon running. This can be found in the includes folder. Should these not be available you will need to ensure that the \bin\<Build> folder contains System.Data.SQLite.dll, VimService65.dll and two subfolders (x64, and x86) with the correct SQLite.Interop.dll versions.

**Notes:**
- Datastore Scanning: The Environment Assessment Toolkit uses cached vSphere information. It uses guest integration tool data where possible. This logic will be improved so that it tries guest information first, then if its thin provisioned uses summary data, otherwise it uses VMDK file usage on disk. This means that for some virtual machines vSphere's reported data usage is actually wrong, but this only makes the usage number more conservative, so this is not a really big problem.
- Embedded Database: As the datasets for large environments are quite large the tool now comes with an embedded SQLite database. This is used to store data from the collector which can then be accessed by the web service.
Web Service
- Web Service: The Environment Assessment Web Service continues to run after the collection wizard is complete. This web service parses content from the SQLite database that is included and both hosts file content on 127.0.0.1:8182, as well as listens to 127.0.0.1:8182/api for data requests. This allows the browser to only see part of the entire data set at a time, improving performance.
