# Umbraco 7 as a Headless CMS
Add controllers to /controllers/

## API


### GetAll
Get json by document type name:


/umbraco/api/JSON/getall/news

/umbraco/api/JSON/getall/activity

Get json data from multiple IDs: 


/umbraco/api/JSON/getall/1058,1080,1083

 
### GetList

Get json by document type name (simpler list)

/umbraco/api/JSON/getlist/nyhet

/umbraco/api/JSON/getlist/aktivitet


### GetTree

Get json data with tree structure with/without children: 


/umbraco/api/JSON/gettree/1058

### Get

Get json data from single node: 

/umbraco/api/JSON/get/1061


## Why Umbraco 7 as a Headless CMS?

Being very fond of the umbraco backoffice, and its ease of use to users <br/>
I wanted to have an easy way to get json data for SPAs.
