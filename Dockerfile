FROM bitnami/postgresql:latest


ENV POSTGRES_USER = admin
ENV POSTGRES_PASSWORD = admin@prokeep
ENV POSTGRESQL_DATABASE = prokeep-db



EXPOSE 5432