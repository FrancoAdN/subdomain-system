const express = require('express');
const bodyParser = require('body-parser');
const mysql = require('mysql');


function connectionSQL(){
    const con = mysql.createConnection({
        host: "localhost",
        user: "maxpower_francoadinapoli",
        password: "Fa42904558.;",
        database: "maxpower_subsystem" ,
        multipleStatements: true
    });
    return con;
}

const app = express();

app.use(bodyParser.json({limit:'50mb', extended:true}));

app.use(bodyParser.urlencoded({limit:'50mb', extended:true}));
/*
app.get('/', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `tabla`';
    con.connect(function(err) {
        if (err) throw err;
        con.query(sql, function (err, result, fields) {
          if (err) throw err;
          resp.send(result[0]);
          con.end();
        });
    });
});*/

app.get('/', (req, resp) => {
    resp.send("WELCOME TO THE SYSTEM SERVER OF MAXPOWER INDUSTRIAL AUTOMATION \n\n\n\nTHIS SERVER IS USED TO MAKE REQUESTS");
});

app.listen(3030, () => console.log('Server running'));
