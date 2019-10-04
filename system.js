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
          //PARSING FROM RESULTS TO TABLE
          let index = result[0].id_ext;
          let json = {id: result[0].id_ext, emp: result[0].emp, inco: result[0].incoterm, mon: result[0].moneda,
            pmde: result[0].pmde, fecha: result[0].fecha, orden: result[0].orden, tabla:[{cant: result[0].cant, descr: result[0].descr, punit: result[0].punit}]};
          let arr = []
          for(let i = 1; i < result.length; i++){
              if(result[i].id_ext == index)
                json.tabla.push({cant: result[i].cant, descr: result[i].descr, punit: result[i].punit});
              else{
                  arr.push(json);
                  index = result[i].id_ext;
                  json = {id: result[i].id_ext, emp: result[i].emp, inco: result[i].incoterm, mon: result[i].moneda,
                    pmde: result[i].pmde, fecha: result[i].fecha, orden: result[i].orden, tabla:[{cant: result[i].cant, descr: result[i].descr, punit: result[i].punit}]};
              }
              if(i == result.length -1)
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

app.post('/emp', (req, resp) => {
    let emp = req.body;
    emp.cuit = parseInt(emp.cuit);
    emp.tel = parseInt(emp.tel);
    emp.telb = parseInt(emp.telb);
    emp.telcom = parseInt(emp.telcom);

    console.log(emp);

    resp.send("INSERT DONE");
});
app.listen(3030, () => console.log('Server running'));
