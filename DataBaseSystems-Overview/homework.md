1. What database models do you know?
	 * Hierarchical database model
	 * Network model
	 * Relational model
	 * Entity–relationship model
		 * Enhanced entity–relationship model
	 * Object model
	 * Document model
	 * Entity–attribute–value model
	 
2. Which are the main functions performed by a Relational Database Management System (RDBMS)?
	 * manages the organization, storage, access, security and integrity of data
	 * allows application systems to focus on the user interface, data validation and screen navigation. 
	 * add, modify, delete or display data
	 
3. Define what is "table" in database terms.
	 * A table is a collection of related data held in a structured format within a database. 
	   It consists of fields (columns), and rows.
	   
4. Explain the difference between a primary and a foreign key.
	 * The primary key consists of one or more columns whose data contained within is used to uniquely identify each row in the table. 
	 * A foreign key is a set of one or more columns in a table that refers to the primary key in another table.  
	 
5. Explain the different kinds of relationships between tables in relational databases.
	 * One-to-one: Both tables can have only one record on either side of the relationship. Each primary key value relates to only one (or no) record in the related table. 
	 * One-to-many: The primary key table contains only one record that relates to none, one, or many records in the related table
	 * Many-to-many: Each record in both tables can relate to any number of records (or no records) in the other table. 
	 
6. When is a certain database schema normalized? What are the advantages of normalized databases?
	 * Database normalization (or normalisation) is the process of organizing the columns (attributes) and tables (relations)
       of a relational database to minimize data redundancy.
	   
7. What are database integrity constraints and when are they used?
     * Data integrity is normally enforced in a database system by a series of integrity constraints or rules. Three types of integrity constraints are an inherent part of the relational data model: 
	   entity integrity, referential integrity and domain integrity:
			* Entity integrity
			* Referential integrity
			* Domain integrity
			* User-defined integrity
			
8. Point out the pros and cons of using indexes in a database.
	 * Advantages: use an index for quick access to a database table specific information. 
	   The index is a structure of the database table the value of one or more columns to sort
	 * Disadvantages: too index will affect the speed of update and insert, because it requires the same update each index file.
	 
9. What's the main purpose of the SQL language?
	 *  special-purpose programming language designed for managing data held in a relational database management system (RDBMS), 
	    or for stream processing in a relational data stream management system (RDSMS).
		
10. What are transactions used for?
     * A transaction symbolizes a unit of work performed within a database management system (or similar system) against a database, and treated in a coherent and reliable way independent of other transactions. 
	   A transaction generally represents any change in database.
	 * Example: SELECT * FROM dbo.Employees
	 
11. What is a NoSQL database?
	 * A NoSQL database provides a mechanism for storage and retrieval of data that is modeled in means 
	   other than the tabular relations used in relational databases.
	   
12. Explain the classical non-relational data models.
	 * A non-relational database is a database that does not incorporate the table/key model that relational database management systems (RDBMS) promote.
     * These kinds of databases require data manipulation techniques and processes designed to provide solutions to big data problems that big companies face. 
     * The most popular emerging non-relational database is called NoSQL (Not Only SQL).
	 
13. Give few examples of NoSQL databases and their pros and cons.
	 * pros
		* Mostly open source.
		* Horizontal scalability. 
		* Support for Map/Reduce. 
		* No need to develop fine-grained data model 
		* Easy to use
	 * cons
		* Immaturity.
		* Possible database administration issues. 
		* No indexing support
		* Bad reporting performance.
	 *  Databases:
        * Cassandra (Distributed wide-column database)
        * MongoDB (Mature and powerful JSON-Document database)
        * CouchDB (JSON-based document database with REST API)
        * Redis (Ultra-fast in-memory data structures server)