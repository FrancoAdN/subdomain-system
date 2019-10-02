const express = require('express');
const bodyParser = require('body-parser');
const mysql = require('mysql');

/*
function connectionSQL(){
    const con = mysql.createConnection({
        host: "localhost",
        user: "maxpower_francoadinapoli",
        password: "Fa42904558.;",
        database: "maxpower_db" ,
        multipleStatements: true
    });
    return con;
}

const a = connectionSQL();*/
const app = express();

app.use(bodyParser.json({limit:'50mb', extended:true}));

app.use(bodyParser.urlencoded({limit:'50mb', extended:true}));

app.get('/', (req, resp) => {
    resp.send("NEW SERVER");
});

app.listen(3030, () => console.log('Server running'));
