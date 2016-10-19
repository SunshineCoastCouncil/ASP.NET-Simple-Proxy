# ASP.NET Simple Proxy

This is just a simple proxy page to make client side cross origin requests easy.

It is based on the code sample [ASP.NET Proxy Page](http://www.codeproject.com/Articles/667611/ASP-NET-Proxy-Page-Used-for-Cross-Domain-Requests) at [CodeProject](http://www.codeproject.com).

## Licence

This code is licenced under The Code Project Open License (CPOL) 1.02 (it's 
very permissive).

## Usage

You can add the Proxy.aspx and Proxy.aspx.cs files to an existing solution or
you can also just ftp them up to an Azure WebApp for use with a html & 
javascript app or prototype.

Once you have them in place you should be able to make simple cross origin GET
requests.

A jQuery example to download the data from the url [https://data.sunshinecoast.qld.gov.au/api/views/audi-fbd4/rows.json?accessType=DOWNLOAD](https://data.sunshinecoast.qld.gov.au/api/views/audi-fbd4/rows.json?accessType=DOWNLOAD)...

```
$.ajax({
    url: "/Proxy.aspx?u=https%3A%2F%2Fdata.sunshinecoast.qld.gov.au%2Fapi%2Fviews%2Faudi-fbd4%2Frows.json%3FaccessType%3DDOWNLOAD"
}).done(function (data) {
    console.log(data);
});
```