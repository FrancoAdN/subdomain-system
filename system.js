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


app.get('/', (req, resp) => {
    resp.send("WELCOME TO THE SYSTEM SERVER OF MAXPOWER INDUSTRIAL AUTOMATION \n\n\n\nTHIS SERVER IS USED TO MAKE REQUESTS");
});

app.get('/ord_nac', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `ord_nac`';
    con.connect(function(err) {
        if (err) throw err;
        con.query(sql, function (err, result, fields) {
          if (err) throw err;
          resp.send(result);
          con.end();
        });
    });
});
app.get('/ord_ext', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `ord_ext` oe INNER JOIN `tabla` t ON oe.orden = t.orden';
    con.connect(function(err) {
        if (err) throw err;
        con.query(sql, function (err, result, fields) {
          if (err) throw err;
          let arr = [];
          for(let r of result){
            let json = {id: r.id_ext, emp: r.emp, incoterm: r.incoterm, mon: r.moneda, fecha: r.fecha, pmde: r.pmde, tabla:[], orden: r.orden};
            json.tabla.push(r.cant, r.descr, r.punit);
            arr.push(json);
          }
          resp.send(arr);
          con.end();
        });
    });
});

app.get('/rep_lab', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `rep_lab`';
    con.connect(function(err) {
        if (err) throw err;
        con.query(sql, function (err, result, fields) {
          if (err) throw err;
          resp.send(result);
          con.end();
        });
    });
});
app.get('/asis_tec', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `asis_tec`';
    con.connect(function(err) {
        if (err) throw err;
        con.query(sql, function (err, result, fields) {
          if (err) throw err;
          resp.send(result);
          con.end();
        });
    });
});
app.get('/venta_prod', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `venta_prod`';
    con.connect(function(err) {
        if (err) throw err;
        con.query(sql, function (err, result, fields) {
          if (err) throw err;
          resp.send(result);
          con.end();
        });
    });
});

app.get('/tabla', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `tabla`';
    con.connect(function(err) {
        if (err) throw err;
        con.query(sql, function (err, result, fields) {
          if (err) throw err;
          resp.send(result);
          con.end();
        });
    });
});


app.listen(3030, () => console.log('Server running'));
