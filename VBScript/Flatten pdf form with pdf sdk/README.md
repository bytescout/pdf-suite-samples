## flatten pdf form with pdf sdk in VBScript with ByteScout PDF Suite

### flatten pdf form with pdf sdk in VBScript

Easy to understand coding instructions are written to assist you to try-out the features without the requirement to write your own code. ByteScout PDF Suite helps with flatten pdf form with pdf sdk in VBScript. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

 Want to speed up the application development? Then this VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout PDF Suite. Follow the steps-by-step instructions from the scratch to work and copy and paste code for VBScript into your editor. VBScript application implementation mostly involves various stages of the software development so even if the functionality works please check it with your data and the production environment.

ByteScout PDF Suite is available as a free trial. You may get it from our website along with all other source code samples for VBScript applications.

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

##### ****Flatten Form.vbs:**
    
```
' This example demonstrates how to submit or reset form.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

' Load filled PDF form
pdfDocument.Load("filled_form.pdf")

' Flatten the form
pdfDocument.FlattenDocument()

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->