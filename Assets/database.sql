-- This script was generated by the ERD tool in pgAdmin 4.
-- Please log an issue at https://redmine.postgresql.org/projects/pgadmin4/issues/new if you find any bugs, including reproduction steps.
BEGIN;


CREATE TABLE IF NOT EXISTS public.detail_transaksi
(
    id_detail_transaksi integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    id_transaksi integer NOT NULL,
    id_laptop integer NOT NULL,
    jumlah integer NOT NULL,
    CONSTRAINT detail_transaksi_pkey PRIMARY KEY (id_detail_transaksi)
);

CREATE TABLE IF NOT EXISTS public.laptop
(
    id_laptop integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    nama_laptop character varying(255) COLLATE pg_catalog."default" NOT NULL,
    harga_laptop integer NOT NULL,
    stok integer,
    is_laptop_deleted boolean NOT NULL DEFAULT false,
    CONSTRAINT laptop_pkey PRIMARY KEY (id_laptop)
);

CREATE TABLE IF NOT EXISTS public.transaksi
(
    id_transaksi integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    tanggal_transaksi timestamp without time zone NOT NULL,
    bayar integer NOT NULL,
    CONSTRAINT transaksi_pkey PRIMARY KEY (id_transaksi)
);

ALTER TABLE IF EXISTS public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_id_laptop_fkey FOREIGN KEY (id_laptop)
    REFERENCES public.laptop (id_laptop) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION
    NOT VALID;


ALTER TABLE IF EXISTS public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_id_transaksi_fkey FOREIGN KEY (id_transaksi)
    REFERENCES public.transaksi (id_transaksi) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION
    NOT VALID;

END;