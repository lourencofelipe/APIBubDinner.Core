# Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)
  
## Auth

### Register
``` js
POST {{host}}/auth/register
```
 

#### Register Request
```js
{
    "firstName":"Bruce",
    "lastName":" Iron",
    "email":"bruce.iron@emailreq.com",
    "password":"Pass123"
}
```
#### Register Response
```js
200 OK
```
```js
"id":"d89c2d9a-eb3e-4075095ff-b920b55aa105",
    "firstName":"Bruce",
    "lastName":" Iron",
    "email":"bruce.iron@emailreq.com",
    "token":"e..hbbA"
```

### Login
```js
POST {{host}}/auth/login
```

#### Login Request
```json
{
    "email":"bruce.iron@emailreq.com",
    "password":"Pass123"
}
```
#### Login Response
```json
{
    "id":"d89c2d9a-eb3e-4075095ff-b920b55aa105",
    "firstName":"Bruce",
    "lastName":" Iron",
    "email":"bruce.iron@emailreq.com",
    "token":"e..hbbA"
}
```
