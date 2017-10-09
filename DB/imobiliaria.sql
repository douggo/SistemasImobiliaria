--
-- PostgreSQL database dump
--

-- Dumped from database version 9.6.4
-- Dumped by pg_dump version 9.6.4

-- Started on 2017-09-11 01:19:40

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 1 (class 3079 OID 12387)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 2152 (class 0 OID 0)
-- Dependencies: 1
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 188 (class 1259 OID 28116)
-- Name: alugueis; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE alugueis (
    i_pagamentos integer NOT NULL,
    i_imoveis integer NOT NULL,
    i_pessoas integer NOT NULL,
    i_alugueis integer NOT NULL
);


ALTER TABLE alugueis OWNER TO postgres;

--
-- TOC entry 186 (class 1259 OID 28100)
-- Name: imoveis; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE imoveis (
    i_imoveis integer NOT NULL,
    endereco character varying NOT NULL,
    cidade character varying NOT NULL,
    estado character varying NOT NULL
);


ALTER TABLE imoveis OWNER TO postgres;

--
-- TOC entry 185 (class 1259 OID 28092)
-- Name: pagamentos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE pagamentos (
    i_pagamentos integer NOT NULL,
    parcelas integer NOT NULL,
    valor numeric(15,2) NOT NULL,
    tipo character varying NOT NULL
);


ALTER TABLE pagamentos OWNER TO postgres;

--
-- TOC entry 187 (class 1259 OID 28108)
-- Name: pessoas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE pessoas (
    i_pessoas integer NOT NULL,
    genero character varying NOT NULL,
    cpf character varying NOT NULL,
    endereco character varying NOT NULL,
    nome character varying NOT NULL
);


ALTER TABLE pessoas OWNER TO postgres;

--
-- TOC entry 2145 (class 0 OID 28116)
-- Dependencies: 188
-- Data for Name: alugueis; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY alugueis (i_pagamentos, i_imoveis, i_pessoas, i_alugueis) FROM stdin;
1	1	1	1
2	2	2	2
3	3	3	3
4	4	4	4
\.


--
-- TOC entry 2143 (class 0 OID 28100)
-- Dependencies: 186
-- Data for Name: imoveis; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY imoveis (i_imoveis, endereco, cidade, estado) FROM stdin;
1	Rua Kennedy, Centro, 166	Rio do Sul	SC
2	Rua Cerejeira, Centro, 998	Curitiba	PR
3	Pepsi On Stage, 636	Porto Alegre	RS
4	Anita Garibaldo, 23	Lontras	SC
\.


--
-- TOC entry 2142 (class 0 OID 28092)
-- Dependencies: 185
-- Data for Name: pagamentos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY pagamentos (i_pagamentos, parcelas, valor, tipo) FROM stdin;
1	12	1500.00	Boleto
3	6	122.00	Cartão de Crédito
2	12	1522.00	Boleto
4	6	350.00	À vista
\.


--
-- TOC entry 2144 (class 0 OID 28108)
-- Dependencies: 187
-- Data for Name: pessoas; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY pessoas (i_pessoas, genero, cpf, endereco, nome) FROM stdin;
1	Masculino	000.000.000-00	Rua Blablá	Fabiano Gabardo Lemos
2	Masculino	111.111.111.11	Rua Flores, Boa Vista	Douglas Felipe da Silva
3	Masculino	222.222.222-22	Rua Ladeira Lateral	Lucas Eduardo dos Santos
4	Feminino	333.333.333-33	Rua Traição, Centro	Gabriella Ledra
\.


--
-- TOC entry 2021 (class 2606 OID 28120)
-- Name: alugueis i_alugueis; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY alugueis
    ADD CONSTRAINT i_alugueis PRIMARY KEY (i_pagamentos, i_imoveis, i_pessoas, i_alugueis);


--
-- TOC entry 2017 (class 2606 OID 28107)
-- Name: imoveis i_imoveis; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY imoveis
    ADD CONSTRAINT i_imoveis PRIMARY KEY (i_imoveis);


--
-- TOC entry 2015 (class 2606 OID 28099)
-- Name: pagamentos i_pagamentos; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY pagamentos
    ADD CONSTRAINT i_pagamentos PRIMARY KEY (i_pagamentos);


--
-- TOC entry 2019 (class 2606 OID 28115)
-- Name: pessoas i_pessoas; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY pessoas
    ADD CONSTRAINT i_pessoas PRIMARY KEY (i_pessoas);


--
-- TOC entry 2023 (class 2606 OID 28126)
-- Name: alugueis imoveis_alugueis_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY alugueis
    ADD CONSTRAINT imoveis_alugueis_fk FOREIGN KEY (i_imoveis) REFERENCES imoveis(i_imoveis);


--
-- TOC entry 2022 (class 2606 OID 28121)
-- Name: alugueis pagamentos_alugueis_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY alugueis
    ADD CONSTRAINT pagamentos_alugueis_fk FOREIGN KEY (i_pagamentos) REFERENCES pagamentos(i_pagamentos);


--
-- TOC entry 2024 (class 2606 OID 28131)
-- Name: alugueis pessoas_alugueis_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY alugueis
    ADD CONSTRAINT pessoas_alugueis_fk FOREIGN KEY (i_pessoas) REFERENCES pessoas(i_pessoas);


-- Completed on 2017-09-11 01:19:40

--
-- PostgreSQL database dump complete
--

