
 CREATE TABLE public.cadastro
 (
     id_cadastro INTEGER NOT NULL,
     texto VARCHAR (250) NOT NULL,
     numeros INTEGER NOT NULL,
     CONSTRAINT cadastro_num_check CHECK (numeros > 0),
     CONSTRAINT num_unique UNIQUE (numeros)
  );

ALTER TABLE public.cadastro OWNER TO postgres;

-- sequencia para a tabela cadastro
CREATE SEQUENCE public.cadastro_id_seq
START WITH 1
INCREMENT BY 1
CACHE 1;

ALTER SEQUENCE public.cadastro_id_seq OWNER TO postgres;

ALTER SEQUENCE public.cadastro_id_seq OWNED BY public.cadastro.id_cadastro;

 CREATE TABLE public.log_operacoes (
     id integer NOT NULL,
     data_hora timestamp DEFAULT CURRENT_TIMESTAMP,
     operacao varchar(10) NOT NULL
);

ALTER TABLE public.log_operacoes OWNER TO postgres;

CREATE SEQUENCE public.log_operacoes_id_seq
    START WITH 1
    INCREMENT BY 1
    CACHE 1;

	
ALTER TABLE ONLY public.cadastro
ALTER COLUMN id_cadastro SET DEFAULT nextval('public.cadastro_id_seq'::regclass);



ALTER TABLE public.log_operacoes
ALTER COLUMN id SET DEFAULT nextval('public.log_operacoes_id_seq'::regclass);


ALTER TABLE ONLY public.cadastro
ADD CONSTRAINT cadastro_pkey PRIMARY KEY (id_cadastro);

ALTER TABLE ONLY public.log_operacoes
ADD CONSTRAINT log_operacoes_pkey PRIMARY KEY (id);


ALTER TABLE ONLY public.cadastro
ADD CONSTRAINT num_unique UNIQUE (numeros);
