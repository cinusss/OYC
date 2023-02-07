import { Helmet } from 'react-helmet-async';
import PageHeader from '../../../components/PageHeader/index';
import PageTitleWrapper from 'src/components/PageTitleWrapper';
import { Grid, Container } from '@mui/material';
import Footer from 'src/components/Footer';
import AddCategory from './AddCategory';
import { TextHeader } from 'src/models/text_header';

function ApplicationsTransactions() {
  const textHeader: TextHeader = {
    title: 'Dodaj nową kategorię',
    description: 'Uzupełnij ponizszy formularz, aby dodać nową kategorię.',
    isButton: false
  };
  return (
    <>
      <Helmet>
        <title>Add Category</title>
      </Helmet>
      <PageTitleWrapper>
        <PageHeader textHeader={textHeader} />
      </PageTitleWrapper>
      <Container maxWidth="lg">
        <Grid
          container
          direction="row"
          justifyContent="center"
          alignItems="stretch"
          spacing={3}
        >
          <Grid item xs={12}>
            <AddCategory />
          </Grid>
        </Grid>
      </Container>
      <Footer />
    </>
  );
}

export default ApplicationsTransactions;
