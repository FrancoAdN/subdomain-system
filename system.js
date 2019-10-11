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
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err) {
            console.error(err);
            resp.send("0");
          }
          resp.send(result);
          con.end();
        });
    });
});


app.get('/ord_ext', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `ord_ext` oe INNER JOIN `tabla` t ON oe.orden = t.orden';
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send("0");
          }
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
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }          resp.send(result);
          con.end();
        });
    });
});


app.get('/asis_tec', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `asis_tec`';
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }
          resp.send(result);
          con.end();
        });
    });
});


app.post('/asis_tec', (req, resp) => {
    const data = req.body;
    data.tel = parseInt(data.tel);
    data.precio = parseInt(data.precio);
    const nof = parseInt(data.noferta.split('-')[1]);
    data['conf'] = false;


    const con = connectionSQL();
    const sql =  `INSERT INTO asis_tec (emp, tipo, precio, fdp, det, orden, fecha, confirmado) values ('${data.empresa}', '${data.asistencia}', ${data.precio}, '${data.formadepago}', '${data.detalle}', '${data.noferta}', '${data.fecha}', ${data.conf});
    UPDATE last SET num = ${nof};`;
    con.connect(function(err) {
        if (err){
            console.error(err);
            resp.send('0');
        }
        con.query(sql, function (err, result, fields) {
          if (err){
              console.error(err);
              resp.send('0');
          }
          con.end();
        });
    });

    resp.send("1");
}),


app.get('/venta_prod', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `venta_prod`';
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }
          resp.send(result);
          con.end();
        });
    });
});

app.get('/tabla', (req, resp) => {
    const con = connectionSQL();
    const sql =  'SELECT * FROM `tabla`';
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }
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

    const con = connectionSQL();

    const sql =  "SELECT * FROM `emp` WHERE `emp` = '" + emp.emp  + "';";
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
          if (err){
            console.error(err);
            resp.send("0");
          }else if(result.length == 0){
            const qry = `INSERT into emp (emp, cuit, dir, loc, web, telcom, rub, descrub, cont, mail, tel, contb, mailb, telb) 
            VALUES ('${emp.emp}', ${emp.cuit}, '${emp.dir}', '${emp.loc}', '${emp.web}', ${emp.telcom}, '${emp.rub}', '${emp.esp}', '${emp.cont}', '${emp.mail}', ${emp.tel}, '${emp.contb}', '${emp.mailb}', ${emp.telb});`;
            con.query(qry, function (err, result, fields) {
                if (err){
                    console.error(err);
                    resp.send("0");
                }else{
                    console.log("INSERT DONE");
                    resp.send("1");
                }
            });
          }else{
            resp.send("2");
          }
          con.end();
        });
    });
});


app.get('/emp/:id', (req, resp) => {
    const con = connectionSQL();
    
    let sql = "SELECT * FROM `emp` WHERE";
    if(parseInt(req.params.id))
        sql += " `cuit` = " + req.params.id;
    else
        sql += " `emp` = '" + req.params.id +"';";
    

    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }
          resp.send(result);
          con.end();
        });
    });
});

app.get('/last', (req, resp) => {
    const con = connectionSQL();
    const sql = 'SELECT * FROM last';
    con.connect(function(err) {
        if (err) {
            console.error(err);
            resp.send("0");
        }
        con.query(sql, function (err, result, fields) {
            if (err) {
                console.error(err);
                resp.send("0");
            }
          resp.send(result);
          con.end();
        });
    });
});

app.listen(3030, () => console.log('Server running'));
