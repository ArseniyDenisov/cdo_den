PGDMP     
        	            {            cdo    15.1    15.1 "    '           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            (           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            )           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            *           1262    82022    cdo    DATABASE     w   CREATE DATABASE cdo WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE cdo;
                postgres    false            �            1259    82032    account    TABLE     �   CREATE TABLE public.account (
    "ID" integer NOT NULL,
    "RuleID" integer DEFAULT 1 NOT NULL,
    "Surname" text,
    "Name" text,
    "Patronymic" text
);
    DROP TABLE public.account;
       public         heap    postgres    false            �            1259    82031    account_ID_seq    SEQUENCE     �   ALTER TABLE public.account ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."account_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    217            �            1259    82074    contract    TABLE     D  CREATE TABLE public.contract (
    "ID" integer NOT NULL,
    "ProgramID" integer NOT NULL,
    "Student_FullName" text NOT NULL,
    "Payer_FullName" text NOT NULL,
    "Payer_Address" text NOT NULL,
    "Cost" double precision NOT NULL,
    "Paid" boolean NOT NULL,
    "StartDate" date NOT NULL,
    "Identifier" text
);
    DROP TABLE public.contract;
       public         heap    postgres    false            �            1259    82073    contract_ID_seq    SEQUENCE     �   ALTER TABLE public.contract ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."contract_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    225            �            1259    82057    educational_program    TABLE     �   CREATE TABLE public.educational_program (
    "ID" integer NOT NULL,
    "Title" text NOT NULL,
    "TrainingPeriod" integer NOT NULL,
    "Qualification" text,
    "Cost" double precision NOT NULL
);
 '   DROP TABLE public.educational_program;
       public         heap    postgres    false            �            1259    82056    educational_program_ID_seq    SEQUENCE     �   ALTER TABLE public.educational_program ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."educational_program_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    223            �            1259    82049 
   individual    TABLE     '  CREATE TABLE public.individual (
    "ID" integer NOT NULL,
    "Surname" text,
    "Name" text,
    "Patronymic" text,
    "DateOfBirth" date,
    "PassportSeries" integer,
    "ResidentialAddress" text,
    "Email" text,
    "PhoneNumber" text,
    "PlaceOfWork" text,
    "JobTitile" text
);
    DROP TABLE public.individual;
       public         heap    postgres    false            �            1259    82048    individual_ID_seq    SEQUENCE     �   ALTER TABLE public.individual ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."individual_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    221            �            1259    82041    rule    TABLE     k   CREATE TABLE public.rule (
    "ID" integer NOT NULL,
    "Title" text NOT NULL,
    "Description" text
);
    DROP TABLE public.rule;
       public         heap    postgres    false            �            1259    82040    rule_ID_seq    SEQUENCE     �   ALTER TABLE public.rule ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."rule_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    219            �            1259    82024 	   user_data    TABLE     �   CREATE TABLE public.user_data (
    "ID" integer NOT NULL,
    "AccountID" integer NOT NULL,
    "Login" text NOT NULL,
    "Password" text NOT NULL
);
    DROP TABLE public.user_data;
       public         heap    postgres    false            �            1259    82023    user_data_ID_seq    SEQUENCE     �   ALTER TABLE public.user_data ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."user_data_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    215                      0    82032    account 
   TABLE DATA           R   COPY public.account ("ID", "RuleID", "Surname", "Name", "Patronymic") FROM stdin;
    public          postgres    false    217   �&       $          0    82074    contract 
   TABLE DATA           �   COPY public.contract ("ID", "ProgramID", "Student_FullName", "Payer_FullName", "Payer_Address", "Cost", "Paid", "StartDate", "Identifier") FROM stdin;
    public          postgres    false    225   '       "          0    82057    educational_program 
   TABLE DATA           g   COPY public.educational_program ("ID", "Title", "TrainingPeriod", "Qualification", "Cost") FROM stdin;
    public          postgres    false    223   �'                  0    82049 
   individual 
   TABLE DATA           �   COPY public.individual ("ID", "Surname", "Name", "Patronymic", "DateOfBirth", "PassportSeries", "ResidentialAddress", "Email", "PhoneNumber", "PlaceOfWork", "JobTitile") FROM stdin;
    public          postgres    false    221   r(                 0    82041    rule 
   TABLE DATA           <   COPY public.rule ("ID", "Title", "Description") FROM stdin;
    public          postgres    false    219   �(                 0    82024 	   user_data 
   TABLE DATA           K   COPY public.user_data ("ID", "AccountID", "Login", "Password") FROM stdin;
    public          postgres    false    215   �(       +           0    0    account_ID_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public."account_ID_seq"', 3, true);
          public          postgres    false    216            ,           0    0    contract_ID_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."contract_ID_seq"', 6, true);
          public          postgres    false    224            -           0    0    educational_program_ID_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public."educational_program_ID_seq"', 3, true);
          public          postgres    false    222            .           0    0    individual_ID_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."individual_ID_seq"', 1, false);
          public          postgres    false    220            /           0    0    rule_ID_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public."rule_ID_seq"', 3, true);
          public          postgres    false    218            0           0    0    user_data_ID_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."user_data_ID_seq"', 3, true);
          public          postgres    false    214            �           2606    82036    account account_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.account
    ADD CONSTRAINT account_pkey PRIMARY KEY ("ID");
 >   ALTER TABLE ONLY public.account DROP CONSTRAINT account_pkey;
       public            postgres    false    217            �           2606    82078    contract contract_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.contract
    ADD CONSTRAINT contract_pkey PRIMARY KEY ("ID");
 @   ALTER TABLE ONLY public.contract DROP CONSTRAINT contract_pkey;
       public            postgres    false    225            �           2606    82061 ,   educational_program educational_program_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public.educational_program
    ADD CONSTRAINT educational_program_pkey PRIMARY KEY ("ID");
 V   ALTER TABLE ONLY public.educational_program DROP CONSTRAINT educational_program_pkey;
       public            postgres    false    223            �           2606    82053    individual individual_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.individual
    ADD CONSTRAINT individual_pkey PRIMARY KEY ("ID");
 D   ALTER TABLE ONLY public.individual DROP CONSTRAINT individual_pkey;
       public            postgres    false    221            �           2606    82045    rule rule_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.rule
    ADD CONSTRAINT rule_pkey PRIMARY KEY ("ID");
 8   ALTER TABLE ONLY public.rule DROP CONSTRAINT rule_pkey;
       public            postgres    false    219            �           2606    82028    user_data user_data_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.user_data
    ADD CONSTRAINT user_data_pkey PRIMARY KEY ("ID");
 B   ALTER TABLE ONLY public.user_data DROP CONSTRAINT user_data_pkey;
       public            postgres    false    215               �   x�5�A�@ϳ�1��c��xU�ɛ? �&�o����\f���g+��kj�4�8��"����;3�R��^�^Bm��S'r0���x.^Y�$bNK��&SQ��S�$*�Z��+�Y����w<�6;�p�      $   �   x���=
�@���S����f������0���B���J�?�Wx{#'*�������x|3�a��0�v��%r�4�2f2H�<Ls�
�s��0��]������p$��4$��El"�ɰu-�;]ek���t~�l$.�2w���XQq��$bb���@9����,�����j�{rF��a����~입$����:��qd�b�jw�+���TJ]�=;      "   c   x����0C��0�-�-��� �@�� P@�ew#�b�ɖ0#"��Hz����Zc;�RF��Ń 	��7I7"u
[�tMX��D5��e�}���6�             x������ � �         N   x�3�0���;.l���bg���	�\��{a��ƋM.l��ta����1�9 �@��¶[!�1z\\\ �i+         2   x�3�4�4�452400765�44261�2�4B5��s#�CEc���� �I�     