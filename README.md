# SalesManagement

##TO-DO
  - 1.Paging on demand : 
	/customers? page=1&pagesize=100
	{
		"pageNumber":1,
		"result": [....],
		"nextPage": 2
	}
  - 2.Request patterns
	-a.GET: /customers;/customers/{id};/customers/{id}/orders;/customers/{id}?expand=invoices;/v{number}/customers?$orderBy=name
	-b.POST: /customers
  - 2.Sorting on demand
  - 3.Filtering
  - 4.Formatting
	-a. sorting
	-b. filtering
	-c. paging
##API Design Process
	Design
	Implement
	Maintain
	Document
##KISS
##Good HTTP Codes
##Don't leak implementation
##Verbs: 
	GET: DONT mutate data
	PUT;POST;DELETE;PATCH
##AutoMapper: 
	https://automapper.readthedocs.io/en/latest/Getting-started.html
##Paging Sample:
	https://github.com/schneidenbach/AspNetPagingExample/tree/master/src/AspNetPagingExample/Extensions

