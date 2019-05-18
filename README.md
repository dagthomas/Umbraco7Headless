# Umbraco7Headless
Umbraco 7 as a Headless  CMS

Add controller to /controllers/

API: 

Get json by document type name:

/umbraco/api/JSON/getall/news

/umbraco/api/JSON/getall/activity

 
Get:

Get json by document type name (simpler list)

/umbraco/api/JSON/getlist/nyhet

/umbraco/api/JSON/getlist/aktivitet

 
Get json data from multiple IDs: 

/umbraco/api/JSON/getall/1058,1080,1083


Get json data with tree structure with/without children: 

/umbraco/api/JSON/gettree/1058


Get json data from single node: 

/umbraco/api/JSON/get/1061

