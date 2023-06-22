# C# Web API Repository

Some Tools Need to development Web api

    1.Postman

2. **swigger**

### **Need for Web APIs:**

As you can see in the below image, on the left-hand side, we have all three applications and on the right-hand side, we have the database as shown in the below image.

![ASP.NET Core Web API](https://dotnettutorials.net/wp-content/uploads/2020/11/word-image-278.png?ezimgfmt=rs:545x246/rscb1/ng:webp/ngcb1 "ASP.NET Core Web API")

Our goal is to establish communication between all these three applications and the database. So, what we will do? We will add a new Web API Project. This Web API Project will interact with the database. And all three applications will only interact with the Web API Project as shown in the below image.

![Advantages of Web API](https://dotnettutorials.net/wp-content/uploads/2020/11/word-image-279.png?ezimgfmt=rs:691x312/rscb1/ng:webp/ngcb1 "Advantages of Web API")

So, these websites, Android, and iOS applications do not have direct access to the database. They only need to communicate with the Web API project and it is the Web API project’s responsibility to interact with the database. And the entire business logic will be written in the Web API project only and this is the reason why we need Web API for our project. So, Web API acts as a mediator between the front end and backend.

**How Browser and Server Communicate with Each Other**

HTTP stands for HyperText Transport Protocol. HTTP is used for communication between the client and server. Let us understand what it means by client and server with an example.

Suppose, you open the web browser, type the URL in the browser and press the enter button. As soon as you press enter, a request is going to the server (called a web server). Whatever data you are sending from the web browser to the web server is called a Request and whatever data you are receiving from the web server is called a Response. This is how the browser and web server communicate with each other in the form of Requests and Responses. And this type of communication is only possible by using HTTP Protocol. So, the request can be termed as HTTP Request and the response can be called HTTP Response. For a better understanding, please have a look at the following image.

![What is HTTP (Hypertext Transport Protocol)?](https://dotnettutorials.net/wp-content/uploads/2021/03/word-image-306.png?ezimgfmt=rs:614x220/rscb1/ngcb1/notWebP "What is HTTP (Hypertext Transport Protocol)?")

##### **HTTP**

Hypertext Transfer Protocol (often abbreviated to HTTP) is a communications protocol. It is used to send and receive web pages and files on the internet.

The Hypertext Transfer Protocol (HTTP) is an application layer protocol for distributed, collaborative, hypermedia information systems. HTTP is the foundation of data communication for the World Wide Web, where hypertext documents include hyperlinks to other resources that the user can easily access

#### **HTTP Request Components:**

1. **URL** : Each Request must have a unique URL
2. **Verb (Method):** Each Request must have an HTTP Verb.
3. **Header(s):** Each Request can contain one or more Headers.
4. **Body** : Each request can have a body. The body contains the data that we want to send to the server.
5. ![HTTP Request Components](https://dotnettutorials.net/wp-content/uploads/2021/03/word-image-307.png?ezimgfmt=rs:635x243/rscb1/ng:webp/ngcb1 "HTTP Request Components")

##### **HTTP Response Components:**

1. **HTTP Status Code:** It must have a Status Code.
2. **Response Headers:** It can have one or more response headers.
3. **Data** : Response can have data i.e. return to the client.

   ![HTTP Response Components](https://dotnettutorials.net/wp-content/uploads/2021/03/word-image-308.png?ezimgfmt=rs:649x222/rscb1/ng:webp/ngcb1 "HTTP Response Components")
