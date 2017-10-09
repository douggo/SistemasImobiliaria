SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';

SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

CREATE TABLE alugueis (
    i_pagamentos integer NOT NULL,
    i_imoveis integer NOT NULL,
    i_pessoas integer NOT NULL,
    i_alugueis integer NOT NULL
);


ALTER TABLE alugueis OWNER TO postgres;

CREATE TABLE imoveis (
    i_imoveis integer NOT NULL,
    endereco character varying NOT NULL,
    cidade character varying NOT NULL,
    estado character varying NOT NULL
);

ALTER TABLE imoveis OWNER TO postgres;

CREATE TABLE pagamentos (
    i_pagamentos integer NOT NULL,
    parcelas integer NOT NULL,
    valor numeric(15,2) NOT NULL,
    tipo character varying NOT NULL
);

ALTER TABLE pagamentos OWNER TO postgres;

CREATE TABLE pessoas (
    i_pessoas integer NOT NULL,
    genero character varying NOT NULL,
    cpf character varying NOT NULL,
    endereco character varying NOT NULL,
    nome character varying NOT NULL
);

ALTER TABLE pessoas OWNER TO postgres;

ALTER TABLE ONLY alugueis
    ADD CONSTRAINT i_alugueis PRIMARY KEY (i_pagamentos, i_imoveis, i_pessoas, i_alugueis);

ALTER TABLE ONLY imoveis
    ADD CONSTRAINT i_imoveis PRIMARY KEY (i_imoveis);

ALTER TABLE ONLY pagamentos
    ADD CONSTRAINT i_pagamentos PRIMARY KEY (i_pagamentos);

ALTER TABLE ONLY pessoas
    ADD CONSTRAINT i_pessoas PRIMARY KEY (i_pessoas);

ALTER TABLE ONLY alugueis
    ADD CONSTRAINT imoveis_alugueis_fk FOREIGN KEY (i_imoveis) REFERENCES imoveis(i_imoveis);

ALTER TABLE ONLY alugueis
    ADD CONSTRAINT pagamentos_alugueis_fk FOREIGN KEY (i_pagamentos) REFERENCES pagamentos(i_pagamentos);

ALTER TABLE ONLY alugueis
    ADD CONSTRAINT pessoas_alugueis_fk FOREIGN KEY (i_pessoas) REFERENCES pessoas(i_pessoas);