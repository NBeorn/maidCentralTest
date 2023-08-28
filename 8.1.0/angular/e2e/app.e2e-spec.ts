import { maidCentralTestTemplatePage } from './app.po';

describe('maidCentralTest App', function() {
  let page: maidCentralTestTemplatePage;

  beforeEach(() => {
    page = new maidCentralTestTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
