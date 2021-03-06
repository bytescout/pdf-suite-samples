## How to split PDF document with PDF extractor SDK in C++ and ByteScout PDF Suite

### This code in C++ shows how to split PDF document with PDF extractor SDK with this how to tutorial

The sample shows instructions and algorithm of how to split PDF document with PDF extractor SDK and how to make it run in your C++ application. ByteScout PDF Suite: the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can split PDF document with PDF extractor SDK in C++.

 These C++ code samples for C++ guide developers to speed up coding of the application when using ByteScout PDF Suite.  Simply copy and paste in your C++ project or application you and then run your app! Applying C++ application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

Our website gives trial version of ByteScout PDF Suite for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****CPPExample.cpp:**
    
```
	#include "stdafx.h"
	#include "comip.h"

	// you may also refer to the tlb from \net4.00\ folder
	// you may also want to include the tlb file into the project so you could compile it and use intellisense for it
	#import "c:\\Program Files\\Bytescout PDF Extractor SDK\\net2.00\\Bytescout.PDFExtractor.tlb" raw_interfaces_only

	using namespace Bytescout_PDFExtractor;

	int _tmain(int argc, _TCHAR* argv[])
	{
		// Initialize COM.
		HRESULT hr = CoInitializeEx(NULL, COINIT_APARTMENTTHREADED);

		// Create the interface pointer.
		_DocumentSplitterPtr pIDocumentSplitter(__uuidof(DocumentSplitter));

		// Set the registration name and key
		// Note: You should use _bstr_t or BSTR to pass string to the library because of COM requirements
		_bstr_t bstrRegName(L"DEMO"); 
		pIDocumentSplitter->put_RegistrationName(bstrRegName);
		
		_bstr_t bstrRegKey(L"DEMO");
		pIDocumentSplitter->put_RegistrationKey(bstrRegKey);

		// you may enable optimization for extracted pages from documents
		// pIDocumentSplitter->put_OptimizeSplittedDocuments = true;

		// Load sample PDF document
		HRESULT sRes = S_OK;
		//1. extract selected pages (!note: page numbers are 1-based)
		_bstr_t bstrPath(L"..\\..\\sample2.pdf");
		_bstr_t bstrParam(L"page2.pdf");
		sRes = pIDocumentSplitter->ExtractPage(bstrPath, bstrParam, 2);

		// 2. split the doc into 2 parts at page #2
		// (!) Note: page numbers are 1-based
		_bstr_t bstrPathInput(L"..\\..\\sample2.pdf");
		_bstr_t bstrParam1(L"part1.pdf");
		_bstr_t bstrParam2(L"part2.pdf");
		sRes = pIDocumentSplitter->Split(bstrPathInput, bstrParam1, bstrParam2, 2);

		// 3. merge page 2 extracted on step 1 along with base pdf
		// Create the interface pointer.
		_DocumentMergerPtr pIDocumentMerger(__uuidof(DocumentMerger));
		//_bstr_t bstrRegName(L"DEMO"); 
		pIDocumentMerger->put_RegistrationName(bstrRegName);		
		//_bstr_t bstrRegKey(L"DEMO");
		pIDocumentMerger->put_RegistrationKey(bstrRegKey);

		// merge 2 files into the 3rd one
		_bstr_t bstrParamMerge1(L"page2.pdf");
		_bstr_t bstrParamMerge2(L"..\\..\\sample2.pdf");
		_bstr_t bstrParamMergeOutput(L"merged.pdf");

		sRes = pIDocumentMerger->Merge2(bstrParamMerge1, bstrParamMerge2,bstrParamMergeOutput);

		// finally release both instances
		pIDocumentSplitter->Release();
		pIDocumentMerger->Release();

		// uninitialize ActiveX COM support
		CoUninitialize();

		return 0;
	}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****stdafx.cpp:**
    
```
// stdafx.cpp : source file that includes just the standard includes
// CPPExample.pch will be the pre-compiled header
// stdafx.obj will contain the pre-compiled type information

#include "stdafx.h"

// TODO: reference any additional headers you need in STDAFX.H
// and not in this file

```

<!-- code block end -->    

<!-- code block begin -->

##### ****stdafx.h:**
    
```
// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently
//

#pragma once

#include "targetver.h"

#include <stdio.h>
#include <tchar.h>



// TODO: reference additional headers your program requires here

```

<!-- code block end -->    

<!-- code block begin -->

##### ****targetver.h:**
    
```
#pragma once

// Including SDKDDKVer.h defines the highest available Windows platform.

// If you wish to build your application for a previous Windows platform, include WinSDKVer.h and
// set the _WIN32_WINNT macro to the platform you wish to support before including SDKDDKVer.h.

#include <SDKDDKVer.h>

```

<!-- code block end -->