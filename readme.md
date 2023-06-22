![1687450355141](image/readme/1687450355141.png)

# C# Web API Repository

Some Tools Need to development Web api

    1.Postman

2. **swigger**

### **Need for Web APIs:**

As you can see in the below image, on the left-hand side, we have all three applications and on the right-hand side, we have the database as shown in the below image.

![ASP.NET Core Web API](https://dotnettutorials.net/wp-content/uploads/2020/11/word-image-278.png?ezimgfmt=rs:545x246/rscb1/ng:webp/ngcb1 "ASP.NET Core Web API")

Our goal is to establish communication between all these three applications and the database. So, what we will do? We will add a new Web API Project. This Web API Project will interact with the database. And all three applications will only interact with the Web API Project as shown in the below image.

![1687445332888](image/readme/1687445332888.png)

So, these websites, Android, and iOS applications do not have direct access to the database. They only need to communicate with the Web API project and it is the Web API project’s responsibility to interact with the database. And the entire business logic will be written in the Web API project only and this is the reason why we need Web API for our project. So, Web API acts as a mediator between the front end and backend.

**How Browser and Server Communicate with Each Other**

HTTP stands for HyperText Transport Protocol. HTTP is used for communication between the client and server. Let us understand what it means by client and server with an example.

Suppose, you open the web browser, type the URL in the browser and press the enter button. As soon as you press enter, a request is going to the server (called a web server). Whatever data you are sending from the web browser to the web server is called a Request and whatever data you are receiving from the web server is called a Response. This is how the browser and web server communicate with each other in the form of Requests and Responses. And this type of communication is only possible by using HTTP Protocol. So, the request can be termed as HTTP Request and the response can be called HTTP Response. For a better understanding, please have a look at the following image.

![1687445352197](image/readme/1687445352197.png)

##### **HTTP**

Hypertext Transfer Protocol (often abbreviated to HTTP) is a communications protocol. It is used to send and receive web pages and files on the internet.

The Hypertext Transfer Protocol (HTTP) is an application layer protocol for distributed, collaborative, hypermedia information systems. HTTP is the foundation of data communication for the World Wide Web, where hypertext documents include hyperlinks to other resources that the user can easily access

#### **HTTP Request Components:**

1. **URL** : Each Request must have a unique URL
2. **Verb (Method):** Each Request must have an HTTP Verb.
3. **Header(s):** Each Request can contain one or more Headers.
4. **Body** : Each request can have a body. The body contains the data that we want to send to the server.

   ![1687445365607](image/readme/1687445365607.png)

##### **HTTP Response Components:**

1. **HTTP Status Code:** It must have a Status Code.
2. **Response Headers:** It can have one or more response headers.
3. **Data** : Response can have data i.e. return to the client.

   ![1687445431337](image/readme/1687445431337.png)

##### **HTTP Verbs or HTTP Methods:**

**GET Method:**

The GET HTTP Method is used to Retrieve the Data. The HTTP GET method requests a representation of the specified resource. Requests using GET should only be used to request data (they shouldn’t include data)

**POST Method:**

The POST request is used to make a new entry in the database. It is not only specific to a database, whenever you want to create a new resource in your application, then you need to use the POST method.

**PUT Method:**

PUT is also one of the HTTP Verb. The PUT method is used to update all the properties of the current resource in the database. What does it mean? For Example, we have a table called Product in our database. If we want to update all properties of a particular product (i.e. current resource) then we need to use PUT HTTP Request. So, whenever you want to update all the properties (column) of a resource (existing record in the database), then you need to use PUT Method. You cannot add a new resource using the PUT method.

**PATCH Method:**

There are some situations where you don’t want to update all the properties of an existing resource instead you want to update a few of the properties, then you need to use the PATCH method. So, the PATCH method is similar to the PUT method, but it is used to update a few properties of the current resource in the database

**DELETE Method:**

The DELETE method is used to delete the resource from the database. That means you are removing or deleting an existing entity from your database. In modern applications, we use two concepts for deletion. One is Soft Delete and the other one is Hard Delete.

1. **Soft Delete:** In your table, if you have some column like IsDeleted or IsActive, or something similar to this and you just want to update that column, then you cannot use Delete Method. In that case, you need to use the PATCH method. This is because you are not deleting the record from the database, you just update the record.
2. **Hard Delete:** If you want to remove the existing entity from the table, then you need to use the DELETE method. For example, Delete an existing product from the Product table in the database, etc.

##### **HTTP Status Codes:**

The HyperText Transport Protocol status code is also one of the important components of HTTP Response. The Status code is issued from the server and they give information about the response. Whenever we get any response from the server to the client, in that HTTP Response, we must have one HTTP Status code. All the HTTP Status codes are divided into five categories. They are as follows. Here, XX will represent the actual number.

1. **1XX** : Informational Response (Ex: 100, 101, 102, etc.)
2. **2XX** : Successful, whenever you get 2XX as the response code, it means the request is successful. (Ex. 200, 201, 203, etc.)
3. **3XX** : Redirection, whenever you get 3XX as the response code, it means it is re-directional i.e. some re-directional is happening on the server. (Ex. 300, 301, etc.)
4. **4XX** : Client Error, whenever you get 4XX as the response code, it means there is some problem with your request. (Ex: 400, 404, etc.)
5. **5XX** : Server Error. Whenever you get 5XX as the response code, it means there is some problem in the server. (Ex: 500, etc.).

## **SP.NET Core Web API using Postman**

![1687449729714](image/readme/1687449729714.png)

![1687449778196](image/readme/1687449778196.png)

![1687449904867](image/readme/1687449904867.png)

![1687449923852](image/readme/1687449923852.png)

![1687449957300](image/readme/1687449957300.png)

##### **Selecting HTTP Method:**

![1687449986105](image/readme/1687449986105.png)

##### **Enter the Request URL:**

![1687450016341](image/readme/1687450016341.png)

**Params:** If you want to send any parameters then you need to set those parameters as key-value pairs in the Params tab. In our example, we not going to pass any parameters to the Web API, so we keep this empty.

##### **Authorization**

![1687450075642](image/readme/1687450075642.png)

##### **Headers:**

The next one is the Headers tab. As you can see, the postman by default sends the following headers to the Web API. If your API needs some additional headers, then you can set those headers here only in the form of Key-Value Pairs. In our example, the API does not require any additional headers. So, we are only going with the default headers.

![1687450137898](image/readme/1687450137898.png)

##### **Body:**

If your API accepts some data in the body, then you can send such data in the body tab. Further depending upon the type of data you can choose form-data, raw, binary, etc as shown in the below image. As our API is a GET request, as it doesn’t require any data, so none is selected by default.

![1687450187721](image/readme/1687450187721.png)

![1687450220118](image/readme/1687450220118.png)

![1687450237850](image/readme/1687450237850.png)

![1687450253331](image/readme/1687450253331.png)

![1687450517979](image/readme/1687450517979.png)

![1687450546131](image/readme/1687450546131.png)

![1687450574399](image/readme/1687450574399.png)

![1687450724554](image/readme/1687450724554.png)
